using System.Collections.Concurrent;
using PortfolioApp.Models;

namespace PortfolioApp.Data;

/// <summary>
/// In-memory, thread-safe comment store. Comments are associated strictly by
/// ProjectId so each of the 17 projects has its own independent comment thread.
/// This is intentionally not backed by a database, matching the scope of the
/// assignment; the storage boundary is isolated here so it could be swapped
/// for EF Core later without touching controllers or views.
/// </summary>
public static class CommentRepository
{
    private static readonly ConcurrentDictionary<int, List<Comment>> Store = new();
    private static int _nextId = 1;
    private static readonly object IdLock = new();

    public static List<Comment> GetForProject(int projectId)
    {
        return Store.TryGetValue(projectId, out var comments)
            ? comments.OrderByDescending(c => c.CreatedAt).ToList()
            : new List<Comment>();
    }

    public static Comment Add(int projectId, string name, string content)
    {
        var comment = new Comment
        {
            Id = NextId(),
            ProjectId = projectId,
            // Trim only; HTML-encoding of output happens automatically via Razor's
            // @-syntax on render, which is the primary defense against script injection.
            Name = name.Trim(),
            Content = content.Trim(),
            CreatedAt = DateTime.Now
        };

        Store.AddOrUpdate(
            projectId,
            _ => new List<Comment> { comment },
            (_, list) =>
            {
                list.Add(comment);
                return list;
            });

        return comment;
    }

    private static int NextId()
    {
        lock (IdLock)
        {
            return _nextId++;
        }
    }
}
