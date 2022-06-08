using NUnit.Framework;
using Terrasoft.Configuration.Tests;

namespace DemoPipeline.Tests
{
	[TestFixture]
	[MockSettings(RequireMock.All)]
	public class DemoServiceTests : BaseConfigurationTestFixture
	{

		private DemoService _sut;
		protected override void SetUp()
		{
			base.SetUp();
			_sut = new DemoService
			{
				HttpContextAccessor = SetupHttpContextAccessor(UserConnection)
			};
		}

		[Test(Author = "Kirill Krylov", Description = "endpoint returns expecte value")]
		public void GetMethodExample_ShouldReturn()
		{
			//Arrange
			string expected = "OK";

			//Act
			var actual = _sut.GetMethodExample();

			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}
