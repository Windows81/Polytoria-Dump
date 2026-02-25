namespace System.Dynamic.Utils;

[DefaultMember("Item")]
[Token(Token = "0x200023C")]
internal sealed class CacheDict
{
	[Token(Token = "0x200023D")]
	private sealed class Entry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003CE")]
		internal readonly int _hash; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003CF")]
		internal readonly TKey _key; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003D0")]
		internal readonly TValue _value; //Field offset: 0x0

		[Address(RVA = "0xAE0D40", Offset = "0xADFF40", Length = "0x5D")]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8A")]
		internal Entry(int hash, TKey key, TValue value) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CC")]
	private readonly int _mask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40003CD")]
	private readonly Entry<TKey, TValue>[] _entries; //Field offset: 0x0

	[Token(Token = "0x17000227")]
	internal TKey Item
	{
		[Address(RVA = "0x968180", Offset = "0x967380", Length = "0x157")]
		[CalledBy(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
		[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LightLambda), Member = "MakeRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
		[CalledBy(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A89")]
		internal set { } //Length: 343
	}

	[Address(RVA = "0x968060", Offset = "0x967260", Length = "0x90")]
	[CalledBy(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightLambda), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TypeExtensions), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A85")]
	internal CacheDict`2(int size) { }

	[Address(RVA = "0x967A00", Offset = "0x966C00", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A88")]
	internal void Add(TKey key, TValue value) { }

	[Address(RVA = "0x967B50", Offset = "0x966D50", Length = "0x27")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A86")]
	private static int AlignSize(int size) { }

	[Address(RVA = "0x968180", Offset = "0x967380", Length = "0x157")]
	[CalledBy(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightLambda), Member = "MakeRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[CalledBy(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A89")]
	internal void set_Item(TKey key, TValue value) { }

	[Address(RVA = "0x967B80", Offset = "0x966D80", Length = "0xC3")]
	[CalledBy(Type = typeof(Expression), Member = "CreateLambda", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression), typeof(string), typeof(bool), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>)}, ReturnType = typeof(LambdaExpression))]
	[CalledBy(Type = typeof(Expression), Member = "ValidateLambdaArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Expression&), typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Linq.Expressions.ParameterExpression>), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightLambda), Member = "GetRunDelegateCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Func`2<System.Linq.Expressions.Interpreter.LightLambda, System.Delegate>))]
	[CalledBy(Type = typeof(TypeExtensions), Member = "GetParametersCached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase)}, ReturnType = typeof(ParameterInfo[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A87")]
	internal bool TryGetValue(TKey key, out TValue value) { }

}

