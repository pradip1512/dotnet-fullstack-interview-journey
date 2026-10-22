using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_AsyncAwait;

public class TaskItem
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public bool IsCompleted { get; set; }
}
