namespace Mirror;

[Token(Token = "0x2000081")]
public abstract class SyncObject
{
	[CompilerGenerated]
	[Token(Token = "0x2000082")]
	private sealed class <>c
	{
		[Token(Token = "0x40001C1")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40001C2")]
		public static Func<Boolean> <>9__9_0; //Field offset: 0x8
		[Token(Token = "0x40001C3")]
		public static Func<Boolean> <>9__9_1; //Field offset: 0x10

		[Address(RVA = "0x12A4620", Offset = "0x12A3820", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600044A")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600044B")]
		public <>c() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600044C")]
		internal bool <.ctor>b__9_0() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600044D")]
		internal bool <.ctor>b__9_1() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001BE")]
	public Action OnDirty; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001BF")]
	public Func<Boolean> IsRecording; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C0")]
	public Func<Boolean> IsWritable; //Field offset: 0x20

	[Address(RVA = "0x12A3450", Offset = "0x12A2650", Length = "0x1CD")]
	[CalledBy(Type = typeof(SyncIDictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IDictionary`2<TKey, TValue>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyncList`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyncList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyncList`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>", "System.Collections.Generic.IEqualityComparer`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyncSet`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.ISet`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000449")]
	protected SyncObject() { }

	[Token(Token = "0x6000443")]
	public abstract void ClearChanges() { }

	[Token(Token = "0x6000446")]
	public abstract void OnDeserializeAll(NetworkReader reader) { }

	[Token(Token = "0x6000447")]
	public abstract void OnDeserializeDelta(NetworkReader reader) { }

	[Token(Token = "0x6000444")]
	public abstract void OnSerializeAll(NetworkWriter writer) { }

	[Token(Token = "0x6000445")]
	public abstract void OnSerializeDelta(NetworkWriter writer) { }

	[Token(Token = "0x6000448")]
	public abstract void Reset() { }

}

