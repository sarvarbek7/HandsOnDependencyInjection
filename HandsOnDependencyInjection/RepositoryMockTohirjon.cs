namespace HandsOnDependencyInjection
{
	public class RepositoryMockTohirjon : IRepositoryMock
	{
		public string[] GetAllUsers() => throw new NotImplementedException();
		public string GetUserByIndex(int index) => throw new NotImplementedException();
	}
}
