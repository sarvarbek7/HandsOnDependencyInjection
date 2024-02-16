namespace HandsOnDependencyInjection
{
	public class RepositoryMockElyor : IRepositoryMock
	{
		private DatabaseMock database;

		public RepositoryMockElyor(DatabaseMock database)
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


