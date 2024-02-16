namespace HandsOnDependencyInjection
{
	public class RepositoryMock : IRepositoryMock
	{
		private DatabaseMock database;

		public RepositoryMock(DatabaseMock database)
		{
			this.database = database;
		}

		public string[] GetAllUsers() => throw new NotImplementedException();

		public string GetUserByIndex(int index)
		{
			return this.database.Users[index];
		}
	}
}


