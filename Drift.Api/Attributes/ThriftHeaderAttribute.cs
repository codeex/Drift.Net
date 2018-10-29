/*
 * Copyright (C) 2017 Facebook, Inc.
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
    /// Maps a parameter to a Thrift header.
    /// A header is either a Thrift include, a C++ include, or a namespace declaration.
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	public class ThriftHeaderAttribute : System.Attribute
	{
		public string Value { get; set; }

		public ThriftHeaderAttribute(String value)
		{
			this.Value = value;
		}
	}

}