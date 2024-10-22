namespace TodoServerApp.Data.Interfaces
{
	public interface IDataService
	{
		//IEnumerable<TaskItem> GetTaskItems
		Task<IEnumerable<TaskItem>> GetTaskItemsAsync();
	}
}
