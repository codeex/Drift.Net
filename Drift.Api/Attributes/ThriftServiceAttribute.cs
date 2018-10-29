/*
 * Copyright (C) 2012 Facebook, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;

namespace Drift.Api.Attributes
{


	/// <summary>
	/// Marks a class as a service that can be exported with Thrift.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class| AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public sealed class ThriftServiceAttribute : System.Attribute
	{
		public string Value { get; set; }

		/// <summary>
		/// Name to use for this service in generated IDL.
		/// </summary>
		public string IdlName { get; set; }

		public ThriftServiceAttribute(String value = "", String idlName = "")
		{
			this.Value = value;
			this.IdlName = idlName;
		}
	}

}