﻿/*
 * Copyright (C) 2013 Facebook, Inc.
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
    /// Every Thrift document contains 0 or more headers followed by 0 or more definitions.
    /// </summary>
	[AttributeUsage(AttributeTargets.Method|AttributeTargets.Field| AttributeTargets.Property | AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	public class ThriftDocumentationAttribute : Attribute
	{
		public string[] Value { get; set; }

		public ThriftDocumentationAttribute(String[] value)
		{
			this.Value = value;
		}
	}

}