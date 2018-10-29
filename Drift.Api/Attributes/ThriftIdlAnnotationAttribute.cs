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
namespace Drift.Api.Attributes
{
	public class ThriftIdlAnnotationAttribute : System.Attribute
	{
		public readonly string RECURSIVE_REFERENCE_ANNOTATION_KEY = "drift.recursive_reference";

		public string Key { get; set; }

		public string Value { get; set; }

		public ThriftIdlAnnotationAttribute(string key = "", string value = "")
		{
			this.Key = key;
			this.Value = value;
		}
	}

}