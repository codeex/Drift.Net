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
	/// Marks a field, method or parameter as a Thrift field.
	/// </summary>
	[AttributeUsage(AttributeTargets.Parameter |AttributeTargets.Method| AttributeTargets.Field| AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
	public sealed class ThriftFieldAttribute : Attribute
	{
        /// <summary>
        /// 创建 <see cref="ThriftFieldAttribute"/> 类的新实例。
        /// </summary>
        /// <param name="id">表示字段的顺序，在一个 struct 内应该保持唯一。</param>
        public ThriftFieldAttribute(ThriftIdlAnnotationAttribute[] idlAnnotations, short value = short.MinValue, bool isLegacyId = false, String name = "", Requiredness requiredness = Requiredness.UNSPECIFIED, Recursiveness isRecursive = Recursiveness.UNSPECIFIED)
        {
            this.IdlAnnotations = idlAnnotations?.ToArray();
            this.Value = value;
            this.IsLegacyId = isLegacyId;
            this.IsRecursive = isRecursive;
            this.Requiredness = requiredness;
            this.Name = name;

        }
        /// <summary>
        /// 获取或设置字段的 IDL 名称，如果为 null 或空串序列化时将使用字段名。
        /// </summary>
        public String Name { get; set; }        

        /// <summary>
        ///  获取或设置一个值，指示字段的必要性。
        /// </summary>
        public Requiredness Requiredness { get; set; }

        /// <summary>
        /// 获取或设置一个值，表示字段是否是存在递归的引用。
        /// </summary>
        public Recursiveness IsRecursive { get; set; }

        /// <summary>
        /// 获取或设置字段的 IDL 顺序（顺序必要保证一个 struct 内唯一）。
        /// </summary>
        public short Value { get; set; }

		/// <summary>
		/// Indicates this ThriftField has a negative ID, which is deprecated.
		/// </summary>
		public bool IsLegacyId { get; set; }
		
		public ThriftIdlAnnotationAttribute[] IdlAnnotations	{ get;set;}


		
	}
    public  enum Recursiveness
	{
		UNSPECIFIED,
		FALSE,
		TRUE
	}

	/// <summary>
	/// Indicates the behavior for a field when a value is not received, or when the value
	/// of the field is not set when sending.
	/// </summary>
	public enum Requiredness
	{
        /// <summary>
		/// This is the default (unset) value for <seealso cref="ThriftField#requiredness()"/>. It will not
		/// conflict with other explicit settings of <seealso cref="#NONE"/>, <seealso cref="#REQUIRED"/>, or {@link
		/// #OPTIONAL}. If all of the <seealso cref="ThriftField"/> annotations for
		/// a field are left UNSPECIFIED, it will default to <seealso cref="#NONE"/>.
		/// </summary>
		UNSPECIFIED,
		/// <summary>
		/// This behavior is equivalent to leaving out 'optional' and 'required' in thrift IDL
		/// syntax. However, despite the name, this actually does correspond to defined behavior so
		/// if this value is explicitly specified in any annotations, it will conflict with other
		/// annotations that specify either <seealso cref="#OPTIONAL"/> or <seealso cref="#REQUIRED"/> for the same
		/// field.
		/// <para>
		/// The serialization behavior is that {@code null} values will not be serialized, but
		/// if the field is non-nullable (i.e. it's type is primitive) it will be serialized, even
		/// if the field was not explicitly set.
		/// </para>
		/// <para>
		/// The deserialization behavior is similar: When no value is read, the field will be set
		/// to {@code null} if the type of the field is nullable, but for primitive types the
		/// field will be left untouched (so it will hold the default value for the type).
		/// </para>
		/// </summary>
		NONE,
		/// <summary>
		/// This behavior indicates that the field will always be serialized (and it is an error if the
		/// value is {@code null}), and must always be deserialized (and it is an error if a value
		/// is not read).
		/// </summary>
		REQUIRED,
		/// <summary>
		/// This behavior indicates that it is always ok if the field is {@code null} when serializing,
		/// and that it is always ok to not read a value (and the field will be set to {@code null}
		/// when this happens). As such, primitive types should be replaced with boxed types, so that
		/// null is always a possibility.
		/// </summary>
		OPTIONAL
	}
}