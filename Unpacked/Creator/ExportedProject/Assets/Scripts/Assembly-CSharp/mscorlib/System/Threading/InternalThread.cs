namespace System.Threading;

[Token(Token = "0x2000240")]
internal sealed class InternalThread : CriticalFinalizerObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A6B")]
	private int lock_thread_id; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A6C")]
	private IntPtr handle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A6D")]
	private IntPtr native_handle; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A6E")]
	private IntPtr name_chars; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A6F")]
	private int name_free; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000A70")]
	private int name_length; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A71")]
	private ThreadState state; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A72")]
	private object abort_exc; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A73")]
	private int abort_state_handle; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A74")]
	internal long thread_id; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A75")]
	private IntPtr debugger_thread; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A76")]
	private UIntPtr static_data; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A77")]
	private IntPtr runtime_thread_info; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000A78")]
	private object current_appcontext; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000A79")]
	private object root_domain_thread; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000A7A")]
	internal Byte[] _serialized_principal; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000A7B")]
	internal int _serialized_principal_version; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000A7C")]
	private IntPtr appdomain_refs; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A7D")]
	private int interruption_requested; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000A7E")]
	private IntPtr longlived; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000A7F")]
	internal bool threadpool_thread; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x4000A80")]
	private bool thread_interrupt_requested; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000A81")]
	internal int stack_size; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000A82")]
	internal byte apartment_state; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000A83")]
	internal int critical_region_level; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000A84")]
	internal int managed_id; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000A85")]
	private int small_id; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000A86")]
	private IntPtr manage_callback; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000A87")]
	private IntPtr flags; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000A88")]
	private IntPtr thread_pinning_ref; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000A89")]
	private IntPtr abort_protected_block_count; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000A8A")]
	private int priority; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4000A8B")]
	private IntPtr owned_mutex; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000A8C")]
	private IntPtr suspended_event; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000A8D")]
	private int self_suspended; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000A8E")]
	private IntPtr thread_state; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000A8F")]
	private IntPtr netcore0; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000A90")]
	private IntPtr netcore1; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000A91")]
	private IntPtr netcore2; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000A92")]
	private IntPtr last; //Field offset: 0x120

	[Address(RVA = "0x152B050", Offset = "0x152A250", Length = "0x11")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012E7")]
	public InternalThread() { }

	[Address(RVA = "0x152AFE0", Offset = "0x152A1E0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DCD0")]
	[Calls(Type = typeof(CriticalFinalizerObject), Member = "Finalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012E6")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x152B040", Offset = "0x152A240", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DCD0")]
	[Token(Token = "0x60012E5")]
	private void Thread_free_internal() { }

}

