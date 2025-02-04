using FluentAssertions;
using Newtonsoft.Json;
using VkNet.Model;
using Xunit;

namespace VkNet.Tests.Models
{


	public class TimetableTests : BaseTest
	{
		[Fact]
		public void TimetableToJson()
		{
			ReadJsonFile("Models", nameof(TimetableToJson));

			var timetable = new Timetable()
			{
				Monday = new TimetableItem
				{
					OpenTime = 1080,
					CloseTime = 1380
				},
				Tuesday = new TimetableItem
				{
					OpenTime = 1080,
					CloseTime = 1380
				},
				Wednesday = new TimetableItem
				{
					OpenTime = 1080,
					CloseTime = 1320
				},
				Thursday = new TimetableItem
				{
					OpenTime = 1080,
					CloseTime = 1320
				},
				Friday = new TimetableItem
				{
					OpenTime = 1080,
					CloseTime = 1320
				},
				Saturday = new TimetableItem
				{
					OpenTime = 1080,
					CloseTime = 1320,
					BreakOpenTime = 1200,
					BreakCloseTime = 1230
				},
			};

			JsonConvert.SerializeObject(timetable, Formatting.Indented).Replace("\r", "").Replace("\n", "").Should().Be(Json.Replace("\r", "").Replace("\n", ""));
		}
	}
}
