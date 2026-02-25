namespace System.Buffers;

[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
[Token(Token = "0x200060A")]
internal sealed class ArrayPoolEventSource : EventSource
{
	[Token(Token = "0x200060B")]
	public enum BufferAllocatedReason
	{
		Pooled = 0,
		OverMaximumSize = 1,
		PoolExhausted = 2,
	}

	[Token(Token = "0x4001894")]
	internal static readonly ArrayPoolEventSource Log; //Field offset: 0x0

	[Address(RVA = "0x143B430", Offset = "0x143A630", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(short), typeof(short), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C4D")]
	private static ArrayPoolEventSource() { }

	[Address(RVA = "0x143B530", Offset = "0x143A730", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(short), typeof(short), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002C47")]
	private ArrayPoolEventSource() { }

	[Address(RVA = "0x143B100", Offset = "0x143A300", Length = "0xDF")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Rent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Event(2, Level = EventLevel::Informational (4))]
	[Token(Token = "0x6002C49")]
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, BufferAllocatedReason reason) { }

	[Address(RVA = "0x143B1E0", Offset = "0x143A3E0", Length = "0xC2")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Rent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Event(1, Level = EventLevel::Verbose (5))]
	[Token(Token = "0x6002C48")]
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[Address(RVA = "0x143B2B0", Offset = "0x143A4B0", Length = "0x27")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Return", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Event(3, Level = EventLevel::Verbose (5))]
	[Token(Token = "0x6002C4A")]
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	[Address(RVA = "0x143B400", Offset = "0x143A600", Length = "0x27")]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1<T>+MemoryPressure<T>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(EventSource), Member = "WriteEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Event(4, Level = EventLevel::Informational (4))]
	[Token(Token = "0x6002C4B")]
	internal void BufferTrimmed(int bufferId, int bufferSize, int poolId) { }

	[Address(RVA = "0x143B2E0", Offset = "0x143A4E0", Length = "0x11A")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Trim", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Event(5, Level = EventLevel::Informational (4))]
	[Token(Token = "0x6002C4C")]
	internal void BufferTrimPoll(int milliseconds, int pressure) { }

}

