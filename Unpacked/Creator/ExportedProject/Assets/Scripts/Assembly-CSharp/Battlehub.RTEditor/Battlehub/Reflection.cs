namespace Battlehub;

[Extension]
[Token(Token = "0x2000007")]
public static class Reflection
{
	[CompilerGenerated]
	[Token(Token = "0x2000008")]
	private sealed class <>c
	{
		[Token(Token = "0x4000007")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000008")]
		public static Func<PropertyInfo, Boolean> <>9__9_0; //Field offset: 0x8
		[Token(Token = "0x4000009")]
		public static Func<FieldInfo, Boolean> <>9__10_0; //Field offset: 0x10
		[Token(Token = "0x400000A")]
		public static Func<Assembly, IEnumerable`1<Type>> <>9__14_0; //Field offset: 0x18

		[Address(RVA = "0x5D8370", Offset = "0x5D7570", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600001D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001E")]
		public <>c() { }

		[Address(RVA = "0x395F80", Offset = "0x395180", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000021")]
		internal IEnumerable<Type> <GetAssignableFromTypes>b__14_0(Assembly s) { }

		[Address(RVA = "0x5D8010", Offset = "0x5D7210", Length = "0xF7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FieldInfo), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000020")]
		internal bool <GetSerializableFields>b__10_0(FieldInfo f) { }

		[Address(RVA = "0x5D8110", Offset = "0x5D7310", Length = "0x152")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600001F")]
		internal bool <GetSerializableProperties>b__9_0(PropertyInfo p) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000009")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000B")]
		public Type type; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000022")]
		public <>c__DisplayClass14_0() { }

		[Address(RVA = "0x5D8290", Offset = "0x5D7490", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000023")]
		internal bool <GetAssignableFromTypes>b__1(Type p) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200000A")]
	private sealed class <GetTypesWithAttribute>d__2 : IEnumerable<KeyValuePair`2<Type, Object>>, IEnumerable, IEnumerator<KeyValuePair`2<Type, Object>>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000C")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000D")]
		private KeyValuePair<Type, Object> <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400000E")]
		private int <>l__initialThreadId; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000F")]
		private Assembly assembly; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000010")]
		public Assembly <>3__assembly; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000011")]
		private Type attribute; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000012")]
		public Type <>3__attribute; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000013")]
		private Type[] <>7__wrap1; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000014")]
		private int <>7__wrap2; //Field offset: 0x58

		[Token(Token = "0x17000001")]
		private override KeyValuePair<Type, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type,System.Object>>.Current
		{
			[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
			[CallerCount(Count = 0)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000027")]
			private get { } //Length: 11
		}

		[Token(Token = "0x17000002")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5D7F60", Offset = "0x5D7160", Length = "0x45")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[DebuggerHidden]
			[Token(Token = "0x6000029")]
			private get { } //Length: 69
		}

		[Address(RVA = "0x5D7FB0", Offset = "0x5D71B0", Length = "0x2E")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000024")]
		public <GetTypesWithAttribute>d__2(int <>1__state) { }

		[Address(RVA = "0x5D7D00", Offset = "0x5D6F00", Length = "0x164")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000026")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5D7E70", Offset = "0x5D7070", Length = "0xAD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600002A")]
		private override IEnumerator<KeyValuePair`2<Type, Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type,System.Object>>.GetEnumerator() { }

		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000027")]
		private override KeyValuePair<Type, Object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type,System.Object>>.get_Current() { }

		[Address(RVA = "0x5D7E70", Offset = "0x5D7070", Length = "0xAD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600002B")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5D7F60", Offset = "0x5D7160", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[DebuggerHidden]
		[Token(Token = "0x6000029")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5D7F20", Offset = "0x5D7120", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000028")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000025")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x5D14B0", Offset = "0x5D06B0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000016")]
	public static Type BaseType(Type type) { }

	[Address(RVA = "0x755F30", Offset = "0x755130", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FieldInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public static FieldInfo FieldInfo(string name) { }

	[Address(RVA = "0x5D14E0", Offset = "0x5D06E0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000014")]
	public static Type[] GetAllFromCurrentAssembly() { }

	[Address(RVA = "0x5D1590", Offset = "0x5D0790", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public static string GetAssemblyQualifiedName(Type type) { }

	[Address(RVA = "0x5D16A0", Offset = "0x5D08A0", Length = "0x1F5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AppDomain), Member = "GetAssemblies", ReturnType = typeof(Assembly[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerable), Member = "SelectMany", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Collections.Generic.IEnumerable`1<System.Object>>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000015")]
	public static Type[] GetAssignableFromTypes(Type type) { }

	[Address(RVA = "0x5D18A0", Offset = "0x5D0AA0", Length = "0x9B")]
	[CalledBy(Type = typeof(Reflection), Member = "TryConvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	public static object GetDefault(Type type) { }

	[Address(RVA = "0x5D1940", Offset = "0x5D0B40", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000011")]
	public static FieldInfo[] GetSerializableFields(Type type, bool declaredOnly = true) { }

	[Address(RVA = "0x5D1AA0", Offset = "0x5D0CA0", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Where", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Object>))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000010")]
	public static PropertyInfo[] GetSerializableProperties(Type type) { }

	[Address(RVA = "0x5D1C00", Offset = "0x5D0E00", Length = "0x8E")]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.MenuCreator+<>c", Member = "<Awake>b__5_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.Type, System.Object>>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	[IteratorStateMachine(typeof(<GetTypesWithAttribute>d__2))]
	[Token(Token = "0x6000009")]
	public static IEnumerable<KeyValuePair`2<Type, Object>> GetTypesWithAttribute(Assembly assembly, Type attribute) { }

	[Address(RVA = "0x5D1C90", Offset = "0x5D0E90", Length = "0x21F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 5)]
	[Extension]
	[Token(Token = "0x6000008")]
	public static Type GetUnderlyingType(MemberInfo member) { }

	[Address(RVA = "0x5D1EB0", Offset = "0x5D10B0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000019")]
	public static bool IsArray(Type type) { }

	[Address(RVA = "0x5D1ED0", Offset = "0x5D10D0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600001C")]
	public static bool IsClass(Type type) { }

	[Address(RVA = "0x5D1EF0", Offset = "0x5D10F0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600000C")]
	public static bool IsDelegate(Type type) { }

	[Address(RVA = "0x5D1F90", Offset = "0x5D1190", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600001B")]
	public static bool IsEnum(Type type) { }

	[Address(RVA = "0x5D1FC0", Offset = "0x5D11C0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600001A")]
	public static bool IsGenericType(Type type) { }

	[Address(RVA = "0x5D1FF0", Offset = "0x5D11F0", Length = "0x19")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6000018")]
	public static bool IsPrimitive(Type type) { }

	[Address(RVA = "0x5D2010", Offset = "0x5D1210", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600000D")]
	public static bool IsScript(Type type) { }

	[Address(RVA = "0x5D2090", Offset = "0x5D1290", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6000012")]
	private static bool IsSerializable(FieldInfo field) { }

	[Address(RVA = "0x5D2190", Offset = "0x5D1390", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6000013")]
	private static bool IsSerializable(PropertyInfo property) { }

	[Address(RVA = "0x5D22F0", Offset = "0x5D14F0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000017")]
	public static bool IsValueType(Type type) { }

	[Address(RVA = "0x755FA0", Offset = "0x7551A0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	public static PropertyInfo PropertyInfo(string name) { }

	[Address(RVA = "0x5D2310", Offset = "0x5D1510", Length = "0x16C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeConverter))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Reflection), Member = "GetDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	[Token(Token = "0x600000A")]
	public static bool TryConvert(string input, Type type, out object result) { }

}

