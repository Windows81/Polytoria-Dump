namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int), typeof(int)})]
[Token(Token = "0x2000043")]
public struct UnsafeHashMap : IDisposable, IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000094")]
	internal HashMapHelper<TKey> m_Data; //Field offset: 0x0

	[Token(Token = "0x17000012")]
	public bool IsCreated
	{
		[Address(RVA = "0x844CF0", Offset = "0x843EF0", Length = "0x28")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000077")]
		 get { } //Length: 40
	}

	[Address(RVA = "0x844BB0", Offset = "0x843DB0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(HashMapHelper`1), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public override void Dispose() { }

	[Address(RVA = "0x844CF0", Offset = "0x843EF0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000077")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x827680", Offset = "0x826880", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000078")]
	private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

	[Address(RVA = "0x827680", Offset = "0x826880", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000079")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

