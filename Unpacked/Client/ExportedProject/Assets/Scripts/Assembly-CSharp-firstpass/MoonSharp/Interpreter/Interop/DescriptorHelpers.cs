namespace MoonSharp.Interpreter.Interop;

[Extension]
[Token(Token = "0x20000CD")]
public static class DescriptorHelpers
{
	[CompilerGenerated]
	[Token(Token = "0x20000CE")]
	private sealed class <>c
	{
		[Token(Token = "0x400038E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400038F")]
		public static Func<MoonSharpUserDataMetamethodAttribute, String> <>9__7_0; //Field offset: 0x8

		[Address(RVA = "0x32E990", Offset = "0x32DB90", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000895")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000896")]
		public <>c() { }

		[Address(RVA = "0x32E5C0", Offset = "0x32D7C0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000897")]
		internal string <GetMetaNamesFromAttributes>b__7_0(MoonSharpUserDataMetamethodAttribute a) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000CF")]
	private sealed class <GetAllImplementedTypes>d__10 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000390")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000391")]
		private Type <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000392")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000393")]
		private Type t; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000394")]
		public Type <>3__t; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000395")]
		private Type <ot>5__2; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000396")]
		private Type[] <>7__wrap2; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000397")]
		private int <>7__wrap3; //Field offset: 0x48

		[Token(Token = "0x17000118")]
		private override Type System.Collections.Generic.IEnumerator<System.Type>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600089B")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000119")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600089D")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000898")]
		public <GetAllImplementedTypes>d__10(int <>1__state) { }

		[Address(RVA = "0x32E210", Offset = "0x32D410", Length = "0x245")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600089A")]
		private override bool MoveNext() { }

		[Address(RVA = "0x32E460", Offset = "0x32D660", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600089E")]
		private override IEnumerator<Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600089B")]
		private override Type System.Collections.Generic.IEnumerator<System.Type>.get_Current() { }

		[Address(RVA = "0x32E460", Offset = "0x32D660", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600089F")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600089D")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x32E500", Offset = "0x32D700", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600089C")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000899")]
		private override void System.IDisposable.Dispose() { }

	}


	[Address(RVA = "0x31ACC0", Offset = "0x319EC0", Length = "0x109")]
	[CalledBy(Type = typeof(PropertyTableAssigner), Member = "AssignProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "Camelify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000893")]
	public static string Camelify(string name) { }

	[Address(RVA = "0x31ADD0", Offset = "0x319FD0", Length = "0x71")]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "GetGenericMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Extension]
	[IteratorStateMachine(typeof(<GetAllImplementedTypes>d__10))]
	[Token(Token = "0x6000890")]
	public static IEnumerable<Type> GetAllImplementedTypes(Type t) { }

	[Address(RVA = "0x31B2A0", Offset = "0x31A4A0", Length = "0x13F")]
	[CalledBy(Type = typeof(DynValueMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedFamily", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedFamANDAssem", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedFamORAssem", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPrivate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "get_IsNotPublic", ReturnType = typeof(bool))]
	[Extension]
	[Token(Token = "0x6000888")]
	public static string GetClrVisibility(Type type) { }

	[Address(RVA = "0x31B060", Offset = "0x31A260", Length = "0x111")]
	[CalledBy(Type = typeof(FieldMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsFamilyOrAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsFamilyAndAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsFamily", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsPrivate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6000889")]
	public static string GetClrVisibility(FieldInfo info) { }

	[Address(RVA = "0x31AE50", Offset = "0x31A050", Length = "0x20B")]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DescriptorHelpers), Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	[Token(Token = "0x600088A")]
	public static string GetClrVisibility(PropertyInfo info) { }

	[Address(RVA = "0x31B180", Offset = "0x31A380", Length = "0x111")]
	[CalledBy(Type = typeof(DescriptorHelpers), Member = "GetClrVisibility", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "PrepareForWiring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Table)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsFamilyOrAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsFamilyAndAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsFamily", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPrivate", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x600088B")]
	public static string GetClrVisibility(MethodBase info) { }

	[Address(RVA = "0x31B3E0", Offset = "0x31A5E0", Length = "0x123")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "MetaIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryDispatchToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryDispatchToBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	[Token(Token = "0x600088F")]
	public static string GetConversionMethodName(Type type) { }

	[Address(RVA = "0x31B510", Offset = "0x31A710", Length = "0x1A9")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Select", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TResult>"}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600088D")]
	public static List<String> GetMetaNamesFromAttributes(MethodInfo mi) { }

	[Address(RVA = "0x31B6C0", Offset = "0x31A8C0", Length = "0x1F6")]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(InteropAccessMode)}, ReturnType = typeof(EventMemberDescriptor))]
	[CalledBy(Type = typeof(FieldMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(InteropAccessMode)}, ReturnType = typeof(FieldMemberDescriptor))]
	[CalledBy(Type = typeof(GenericMethodMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode), typeof(bool)}, ReturnType = typeof(GenericMethodMemberDescriptor))]
	[CalledBy(Type = typeof(MethodMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(InteropAccessMode), typeof(bool)}, ReturnType = typeof(MethodMemberDescriptor))]
	[CalledBy(Type = typeof(PropertyMemberDescriptor), Member = "TryCreateIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(InteropAccessMode)}, ReturnType = typeof(PropertyMemberDescriptor))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Enumerable), Member = "OfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IEnumerable)}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(MemberInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = "TSource")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000886")]
	public static Nullable<Boolean> GetVisibilityFromAttributes(MemberInfo mi) { }

	[Address(RVA = "0x31B8C0", Offset = "0x31AAC0", Length = "0xED")]
	[CalledBy(Type = typeof(StandardUserDataDescriptor), Member = "FillMemberList", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x6000887")]
	public static bool IsDelegateType(Type t) { }

	[Address(RVA = "0x31B9B0", Offset = "0x31ABB0", Length = "0x171")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Extension]
	[Token(Token = "0x600088C")]
	public static bool IsPropertyInfoPublic(PropertyInfo pi) { }

	[Address(RVA = "0x31BB30", Offset = "0x31AD30", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000891")]
	public static bool IsValidSimpleIdentifier(string str) { }

	[Address(RVA = "0x31BC20", Offset = "0x31AE20", Length = "0xBC")]
	[CalledBy(Type = "MoonSharp.Interpreter.Platforms.PlatformAutoDetector+<>c", Member = "<AutoDetectPlatformFlags>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Type>))]
	[CalledBy(Type = typeof(TypeDescriptorRegistry), Member = "RegisterAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Extension]
	[Token(Token = "0x600088E")]
	public static Type[] SafeGetTypes(Assembly asm) { }

	[Address(RVA = "0x31BCE0", Offset = "0x31AEE0", Length = "0x182")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000892")]
	public static string ToValidSimpleIdentifier(string str) { }

	[Address(RVA = "0x31BE70", Offset = "0x31B070", Length = "0x98")]
	[CalledBy(Type = typeof(PropertyTableAssigner), Member = "AssignProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "UpperFirstLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000894")]
	public static string UpperFirstLetter(string name) { }

}

