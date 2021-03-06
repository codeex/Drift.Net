﻿using System;

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
    /// <summary>
    /// 标识一个 Thrift 结构（对应 IDL 中的 struct）
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ThriftStructAttribute : System.Attribute
	{
		public string Value { get; set; }

		public Type Builder { get; set; }

		public ThriftIdlAnnotationAttribute[] IdlAnnotations{ get; set; }

		public ThriftStructAttribute( String value = "", Type builder = null)
		{
			this.Value = value;
			this.Builder = builder;
		}
	}

}