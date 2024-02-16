namespace HandsOnDependencyInjection
{
	public class DatabaseMock
	{
		public List<string> Users { get; private set; }

		public DatabaseMock()
		{
			this.Users = ["Test", "Depedency", "Injection"];// ctrl+ A + backspace
		}

		// Yaxshi yaxshi
	}
}
