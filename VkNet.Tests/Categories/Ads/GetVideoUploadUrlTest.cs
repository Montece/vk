﻿using FluentAssertions;
using VkNet.Tests.Infrastructure;
using Xunit;

namespace VkNet.Tests.Categories.Ads
{

	public class GetVideoUploadUrlTest : CategoryBaseTest
	{
		protected override string Folder => "Ads";

		[Fact]
		public void GetVideoUploadUrl()
		{
			Url = "https://api.vk.com/method/ads.getVideoUploadUrl";

			ReadCategoryJsonPath(nameof(Api.Ads.GetVideoUploadUrl));

			var url = Api.Ads.GetVideoUploadUrl();

			url.ToString()
				.Should()
				.Be(
					"https://cs505216.vk.me/upload_video_new.php?act=add_video&oid=16000365&mid=16000365&vid=456239123&fid=0&hash=7d17f2a1e9398a6e363c&tag=2791ceb3&vk=1&full_response=1&swfupload=1");
		}
	}
}