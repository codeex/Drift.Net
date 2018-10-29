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
using System.Linq;

namespace Drift.Api.Attributes
{


	/// <summary>
	/// Marks a method to be exported in a Thrift service.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public class ThriftMethodAttribute : System.Attribute
	{
		public string Value { get; set; }

        public bool Oneway { get; set; }

		public ThriftExceptionAttribute[] Exception { get; set; }		

		public bool Idempotent { get; set; }

		public ThriftMethodAttribute(String value = "", bool oneway = false, bool idempotent = true)
		{
			this.Value = value;
			this.Oneway = oneway;
			//this.Exception = exception?.ToArray();
			this.Idempotent = idempotent;
		}
	}

}