namespace System.Threading;

[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView`1))]
[Token(Token = "0x2000215")]
public class ThreadLocal : IDisposable
{
	[Token(Token = "0x2000219")]
	private class FinalizationHelper
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A01")]
		internal LinkedSlotVolatile<T>[] SlotArray; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A02")]
		private bool m_trackAllValues; //Field offset: 0x0

		[Address(RVA = "0x3E7A20", Offset = "0x3E6C20", Length = "0x44")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011CA")]
		internal FinalizationHelper(LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }

		[Address(RVA = "0xC3EF80", Offset = "0xC3E180", Length = "0x2A2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011CB")]
		protected virtual void Finalize() { }

	}

	[Token(Token = "0x2000218")]
	private class IdManager
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FF")]
		private int m_nextIdToTry; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A00")]
		private List<Boolean> m_freeIds; //Field offset: 0x0

		[Address(RVA = "0xC88130", Offset = "0xC87330", Length = "0x77")]
		[CalledBy(Type = typeof(ThreadLocal`1), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011C9")]
		public IdManager() { }

		[Address(RVA = "0xC87D50", Offset = "0xC86F50", Length = "0x19C")]
		[CalledBy(Type = "UnityEngine.Events.PersistentCall", Member = "get_mode", ReturnType = "UnityEngine.Events.PersistentListenerMode")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextElement", Member = "get_glyphIndex", ReturnType = typeof(uint))]
		[CalledBy(Type = "UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord", Member = "get_featureLookupFlags", ReturnType = "UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags")]
		[CalledBy(Type = "UnityEngine.Touch", Member = "get_type", ReturnType = "UnityEngine.TouchType")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[DeduplicatedMethod]
		[Token(Token = "0x60011C7")]
		internal int GetId() { }

		[Address(RVA = "0xC87EF0", Offset = "0xC870F0", Length = "0xD2")]
		[CalledBy(Type = typeof(ThreadLocal`1), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60011C8")]
		internal void ReturnId(int id) { }

	}

	[Token(Token = "0x2000217")]
	private sealed class LinkedSlot
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FB")]
		internal LinkedSlot<T> Next; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FC")]
		internal LinkedSlot<T> Previous; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FD")]
		internal LinkedSlotVolatile<T>[] SlotArray; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FE")]
		internal T Value; //Field offset: 0x0

		[Address(RVA = "0xCF3DF0", Offset = "0xCF2FF0", Length = "0x36")]
		[CalledBy(Type = typeof(ThreadLocal`1), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadLocal`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ThreadLocal`1), Member = "CreateLinkedSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]", typeof(int), "T"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60011C6")]
		internal LinkedSlot(LinkedSlotVolatile<T>[] slotArray) { }

	}

	[Token(Token = "0x2000216")]
	private struct LinkedSlotVolatile
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FA")]
		internal LinkedSlot<T> Value; //Field offset: 0x0

	}

	[ThreadStatic]
	[Token(Token = "0x40009F3")]
	private static LinkedSlotVolatile<T>[] ts_slotArray; //Field offset: 0xFFFFFFFF
	[ThreadStatic]
	[Token(Token = "0x40009F4")]
	private static FinalizationHelper<T> ts_finalizationHelper; //Field offset: 0xFFFFFFFF
	[Token(Token = "0x40009F7")]
	private static IdManager<T> s_idManager; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F2")]
	private Func<T> m_valueFactory; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F5")]
	private int m_idComplement; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F6")]
	private bool m_initialized; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F8")]
	private LinkedSlot<T> m_linkedSlot; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F9")]
	private bool m_trackAllValues; //Field offset: 0x0

	[Token(Token = "0x170001A7")]
	public bool IsValueCreated
	{
		[Address(RVA = "0xFFAB50", Offset = "0xFF9D50", Length = "0x105")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60011C2")]
		 get { } //Length: 261
	}

	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x170001A6")]
	public T Value
	{
		[Address(RVA = "0xFFAC60", Offset = "0xFF9E60", Length = "0xF0")]
		[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Encrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = "System.ArraySegment`1<Byte>")]
		[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "TryTake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "GetCurrentThreadWorkStealingQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>")]
		[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Awaitable", Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Decrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = "System.ArraySegment`1<Byte>")]
		[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "CompleteExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", "System.Byte[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(ThreadLocal`1), Member = "GetValueSlow", ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x60011BD")]
		 get { } //Length: 240
		[Address(RVA = "0xFFB0C0", Offset = "0xFFA2C0", Length = "0x102")]
		[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "CreateWorkStealingQueueForCurrentThread", ReturnType = "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>")]
		[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Encrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = "System.ArraySegment`1<Byte>")]
		[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Decrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = "System.ArraySegment`1<Byte>")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60011BE")]
		 set { } //Length: 258
	}

	[Address(RVA = "0xFFA730", Offset = "0xFF9930", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IdManager), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011C5")]
	private static ThreadLocal`1() { }

	[Address(RVA = "0xFFA8D0", Offset = "0xFF9AD0", Length = "0x9D")]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LinkedSlot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B6")]
	public ThreadLocal`1() { }

	[Address(RVA = "0xFFAA60", Offset = "0xFF9C60", Length = "0xEC")]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LinkedSlot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B7")]
	public ThreadLocal`1(Func<T> valueFactory) { }

	[Address(RVA = "0xFF8390", Offset = "0xFF7590", Length = "0x2AD")]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(LinkedSlot), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011C1")]
	private void CreateLinkedSlot(LinkedSlotVolatile<T>[] slotArray, int id, T value) { }

	[Address(RVA = "0xFF8A10", Offset = "0xFF7C10", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011BA")]
	public override void Dispose() { }

	[Address(RVA = "0xFF8A80", Offset = "0xFF7C80", Length = "0x2D4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IdManager), Member = "ReturnId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011BB")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0xFF8D60", Offset = "0xFF7F60", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B9")]
	protected virtual void Finalize() { }

	[Address(RVA = "0xFFAB50", Offset = "0xFF9D50", Length = "0x105")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60011C2")]
	public bool get_IsValueCreated() { }

	[Address(RVA = "0xFFAC60", Offset = "0xFF9E60", Length = "0xF0")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Decrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = "System.ArraySegment`1<Byte>")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "CompleteExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", "System.Byte[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "TryTake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Encrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = "System.ArraySegment`1<Byte>")]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "GetCurrentThreadWorkStealingQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "GetValueSlow", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011BD")]
	public T get_Value() { }

	[Address(RVA = "0xFF8DE0", Offset = "0xFF7FE0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011C4")]
	private static int GetNewTableSize(int minSize) { }

	[Address(RVA = "0xFF90B0", Offset = "0xFF82B0", Length = "0x303")]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = "get_Value", ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011BF")]
	private T GetValueSlow() { }

	[Address(RVA = "0xFF9650", Offset = "0xFF8850", Length = "0x26A")]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011C3")]
	private void GrowTable(ref LinkedSlotVolatile<T>[] table, int minLength) { }

	[Address(RVA = "0xFF9940", Offset = "0xFF8B40", Length = "0x75")]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180FE9A00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011B8")]
	private void Initialize(Func<T> valueFactory, bool trackAllValues) { }

	[Address(RVA = "0xFFB0C0", Offset = "0xFFA2C0", Length = "0x102")]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "CreateWorkStealingQueueForCurrentThread", ReturnType = "System.Collections.Concurrent.ConcurrentBag`1<T>+WorkStealingQueue<T>")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Encrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = "System.ArraySegment`1<Byte>")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection", Member = "Decrypt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = "System.ArraySegment`1<Byte>")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "SetValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "LinkedSlotVolatile<T>[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60011BE")]
	public void set_Value(T value) { }

	[Address(RVA = "0xFF99C0", Offset = "0xFF8BC0", Length = "0x46E")]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadLocal`1), Member = "GetValueSlow", ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "CreateLinkedSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]", typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "GrowTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"LinkedSlotVolatile<T>[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011C0")]
	private void SetValueSlow(T value, LinkedSlotVolatile<T>[] slotArray) { }

	[Address(RVA = "0xFFA370", Offset = "0xFF9570", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ThreadLocal`1), Member = "GetValueSlow", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60011BC")]
	public virtual string ToString() { }

}

