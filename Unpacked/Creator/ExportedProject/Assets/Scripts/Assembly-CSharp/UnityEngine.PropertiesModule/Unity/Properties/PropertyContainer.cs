namespace Unity.Properties;

[Token(Token = "0x2000004")]
public static class PropertyContainer
{
	[Token(Token = "0x2000005")]
	private class GetPropertyVisitor : PathVisitor
	{
		[CompilerGenerated]
		[Token(Token = "0x2000006")]
		private sealed class <>c
		{
			[Token(Token = "0x4000009")]
			public static readonly <>c <>9; //Field offset: 0x0

			[Address(RVA = "0x1A18030", Offset = "0x1A17230", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600000D")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600000E")]
			public <>c() { }

			[Address(RVA = "0x1A17E70", Offset = "0x1A17070", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600000F")]
			internal GetPropertyVisitor <.cctor>b__5_0() { }

			[Address(RVA = "0x7FA3C0", Offset = "0x7F95C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000010")]
			internal void <.cctor>b__5_1(GetPropertyVisitor v) { }

		}

		[Token(Token = "0x4000007")]
		public static readonly ObjectPool<GetPropertyVisitor> Pool; //Field offset: 0x0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000008")]
		public IProperty Property; //Field offset: 0xB8

		[Address(RVA = "0x19F5D40", Offset = "0x19F4F40", Length = "0x181")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600000C")]
		private static GetPropertyVisitor() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000B")]
		public GetPropertyVisitor() { }

		[Address(RVA = "0x19F5CC0", Offset = "0x19F4EC0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000009")]
		public virtual void Reset() { }

		[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600000A")]
		protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

	}

	[Token(Token = "0x2000007")]
	private class GetValueVisitor : PathVisitor
	{
		[CompilerGenerated]
		[Token(Token = "0x2000008")]
		private sealed class <>c
		{
			[Token(Token = "0x400000C")]
			public static readonly <>c<TSrcValue> <>9; //Field offset: 0x0

			[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000015")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000016")]
			public <>c() { }

			[Address(RVA = "0x7FA310", Offset = "0x7F9510", Length = "0x5D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000017")]
			internal GetValueVisitor<TSrcValue> <.cctor>b__5_0() { }

			[Address(RVA = "0x7FA3C0", Offset = "0x7F95C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000018")]
			internal void <.cctor>b__5_1(GetValueVisitor<TSrcValue> v) { }

		}

		[Token(Token = "0x400000A")]
		public static readonly ObjectPool<GetValueVisitor`1<TSrcValue>> Pool; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400000B")]
		public TSrcValue Value; //Field offset: 0x0

		[Address(RVA = "0xC589C0", Offset = "0xC57BC0", Length = "0x30E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectPool`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", "System.Action`1<T>", "System.Action`1<T>", "System.Action`1<T>", typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		private static GetValueVisitor`1() { }

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000013")]
		public GetValueVisitor`1() { }

		[Address(RVA = "0xC58610", Offset = "0xC57810", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PathVisitor), Member = "Reset", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000011")]
		public virtual void Reset() { }

		[Address(RVA = "0x604D70", Offset = "0x603F70", Length = "0xC9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE460")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000012")]
		protected virtual void VisitPath(Property<TContainer, TValue> property, ref TContainer container, ref TValue value) { }

	}


	[Address(RVA = "0x73EC70", Offset = "0x73DE70", Length = "0x1F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MissingPropertyBagException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C8F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009BC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), "TContainer&", typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000002")]
	public static void Accept(IPropertyBagVisitor visitor, ref TContainer container, VisitParameters parameters = null) { }

	[Address(RVA = "0x74B420", Offset = "0x74A620", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), "TContainer&", typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public static bool TryAccept(IPropertyBagVisitor visitor, ref TContainer container, VisitParameters parameters = null) { }

	[Address(RVA = "0x74B490", Offset = "0x74A690", Length = "0x5FA")]
	[CalledBy(Type = typeof(PropertyContainer), Member = "Accept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), "TContainer&", typeof(VisitParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), "TContainer&", typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyBagStore), Member = "GetPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, ReturnType = "Unity.Properties.IPropertyBag`1<TContainer>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(PropertyBagStore), Member = "GetPropertyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(IPropertyBag))]
	[Calls(Type = typeof(TypeTraits), Member = "IsContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.StyleEnum`1<System.Int32Enum>>), Member = "CreateComparer", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<UnityEngine.UIElements.StyleEnum`1<System.Int32Enum>>))]
	[Calls(Type = typeof(PropertyBag), Member = "AcceptWithSpecializedVisitor", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>", typeof(IPropertyBagVisitor), "TContainer&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public static bool TryAccept(IPropertyBagVisitor visitor, ref TContainer container, out VisitReturnCode returnCode, VisitParameters parameters = null) { }

	[Address(RVA = "0x7534C0", Offset = "0x7526C0", Length = "0x6C")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "TValue&"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "GetSetValueErrorString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(object), typeof(PropertyPath&), typeof(object), "UnityEngine.UIElements.BindingId&", "TValue"}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryGetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), typeof(IProperty&), typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public static bool TryGetProperty(ref TContainer container, in PropertyPath path, out IProperty property) { }

	[Address(RVA = "0x753200", Offset = "0x752400", Length = "0x2B0")]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryGetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), typeof(IProperty&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&), typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180689250")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807395D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public static bool TryGetProperty(ref TContainer container, in PropertyPath path, out IProperty property, out VisitReturnCode returnCode) { }

	[Address(RVA = "0x753BA0", Offset = "0x752DA0", Length = "0xC7")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "UpdateUI", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BindingContext&", "TValue&"}, ReturnType = "UnityEngine.UIElements.BindingResult")]
	[CalledBy(Type = "UnityEngine.UIElements.DataBinding", Member = "GetSetValueErrorString", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisitReturnCode), typeof(object), typeof(PropertyPath&), typeof(object), "UnityEngine.UIElements.BindingId&", "TValue"}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(PropertyPath), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(PropertyPath&), "TValue&", typeof(VisitReturnCode&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public static bool TryGetValue(ref TContainer container, string name, out TValue value) { }

	[Address(RVA = "0x753930", Offset = "0x752B30", Length = "0x26A")]
	[CalledBy(Type = typeof(PropertyContainer), Member = "TryGetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer&", typeof(string), "TValue&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ObjectPool`1), Member = "Get", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PropertyContainer), Member = "TryAccept", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPropertyBagVisitor), typeof(Object&), typeof(VisitReturnCode&), typeof(VisitParameters)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1807396D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public static bool TryGetValue(ref TContainer container, in PropertyPath path, out TValue value, out VisitReturnCode returnCode) { }

}

