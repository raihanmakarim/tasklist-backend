using System;
namespace test_hyundai_backend.Entities
{
	public class Task
	{
		public int Id { get; set; }
		public required string Title { get; set; }
		public string desc { get; set; } = string.Empty;


	}
}

