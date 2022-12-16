﻿namespace TaskBoardApp.Views.Home
{
    public class HomeViewModel
    {
        public int AllTasksCount { get; init; }
        public List<HomeBoardModel> BoardsWithTasksCount { get; init; }
        public int UserTasksCount { get; init; }
    }
}
