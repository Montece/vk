﻿using System;
using FluentAssertions;
using VkNet.Utils;
using Xunit;

namespace VkNet.Tests.Utils
{

	public class VkParametersTests
	{
		[Fact]
		public void AddNullableBoolean_FalseValue()
		{
			var @params = new VkParameters
			{
				{ "NullableBoolean", false }
			};

			@params.Should().ContainKey("NullableBoolean");
			var val = @params["NullableBoolean"];
			val.Should().Be("0");
		}

		[Fact]
		public void AddNullableBoolean_NullValue()
		{
			var @params = new VkParameters
			{
				{ "NullableBoolean", (bool?) null }
			};

			@params.Should().NotContainKey("NullableBoolean");
		}

		[Fact]
		public void AddNullableBoolean_TrueValue()
		{
			var @params = new VkParameters
			{
				{ "NullableBoolean", true }
			};

			@params.Should().ContainKey("NullableBoolean");
			var val = @params["NullableBoolean"];
			val.Should().Be("1");
		}

		[Fact]
		public void AddDateTime()
		{
			var dateTimeNow = new DateTime(2019,
				10,
				31,
				0,
				21,
				32,
				DateTimeKind.Utc);

			var @params = new VkParameters
			{
				{ "date_time", dateTimeNow }
			};

			FluentActions.Invoking(() =>
				{
					var unused = @params["date_time"];
				})
				.Should()
				.NotThrow();

			@params["date_time"].Should().Be("1572481292");
		}
	}
}