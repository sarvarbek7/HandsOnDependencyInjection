namespace HandsOnDependencyInjection
{
	public interface IRepositoryMock
	{
		string GetUserByIndex(int index);
		string[] GetAllUsers();
	}
}
