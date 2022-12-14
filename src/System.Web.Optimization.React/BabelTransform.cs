/*
 *  Copyright (c) 2014-Present, Facebook, Inc.
 *  All rights reserved.
 *
 *  This source code is licensed under the BSD-style license found in the
 *  LICENSE file in the root directory of this source tree. An additional grant 
 *  of patent rights can be found in the PATENTS file in the same directory.
 */

using React;

namespace System.Web.Optimization.React
{
	/// <summary>
	/// Transforms JavaScript via Babel. Should be included before any minification 
	/// transformations.
	/// </summary>
	public class BabelTransform : IBundleTransform
	{
		/// <summary>
		/// Transforms the content in the <see cref="T:System.Web.Optimization.BundleResponse" /> object.
		/// </summary>
		/// <param name="context">The bundle context.</param>
		/// <param name="response">The bundle response.</param>
		public void Process(BundleContext context, BundleResponse response)
		{
			var environment = ReactEnvironment.Current;
			response.Content = environment.Babel.Transform(response.Content);
		}
	}
}
