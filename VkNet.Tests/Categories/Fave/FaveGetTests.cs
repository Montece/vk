using System.Linq;
using FluentAssertions;
using VkNet.Model.RequestParams.Fave;
using VkNet.Tests.Infrastructure;
using Xunit;

namespace VkNet.Tests.Categories.Fave
{
	public class FaveGetTests : CategoryBaseTest
	{
		/// <inheritdoc />
		protected override string Folder => "Fave";

		[Fact]
		public void Get()
		{
			Url = "https://api.vk.com/method/fave.get";
			ReadCategoryJsonPath(nameof(Get));

			var faves = Api.Fave.Get(new FaveGetParams { Count = 1 });

			var fave = faves.FirstOrDefault();

			faves.Should().NotBeEmpty();
			fave.Should().NotBeNull();
		}
	}
}