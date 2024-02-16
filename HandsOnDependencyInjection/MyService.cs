namespace HandsOnDependencyInjection
{
	public class MyService : IMyService
	{
		private readonly IRepositoryMock repository;

		public MyService(IRepositoryMock repository)
		{
			this.repository = repository;
		}

		public string RetrieveUserByIndex(int index)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException(
					paramName: nameof(index),
					message: "Index must be greater than or equal 0!");
			}

			return this.repository.GetUserByIndex(index);
		}
	}
}
