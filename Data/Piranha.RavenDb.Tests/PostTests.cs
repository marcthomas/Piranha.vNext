﻿/*
 * Copyright (c) 2014 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha.vnext
 * 
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Piranha.RavenDb.Tests
{
	/// <summary>
	/// Tests for the post repository.
	/// </summary>
	[TestClass]
	public class PostTests : Piranha.Tests.Repositories.PostTests
	{
		/// <summary>
		/// Default constructor.
		/// </summary>
		public PostTests() {
			App.Init(c => {
				c.Store = new RavenDb.Store("http://localhost:8080", "piranha.tests", true);
			});
		}

		/// <summary>
		/// Test the post repository.
		/// </summary>
		[TestMethod]
		[TestCategory("RavenDb")]
		public void Posts() {
			base.Run();
		}
	}
}
