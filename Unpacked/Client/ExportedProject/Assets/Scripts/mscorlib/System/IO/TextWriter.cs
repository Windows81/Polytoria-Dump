namespace System.IO;

[Token(Token = "0x2000639")]
public abstract class TextWriter : MarshalByRefObject, IDisposable
{
	[Token(Token = "0x200063A")]
	private sealed class NullTextWriter : TextWriter
	{

		[Token(Token = "0x1700070C")]
		public virtual Encoding Encoding
		{
			[Address(RVA = "0x145DCD0", Offset = "0x145CED0", Length = "0x7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
			[DeduplicatedMethod]
			[Token(Token = "0x6002D9D")]
			 get { } //Length: 7
		}

		[Address(RVA = "0x145E5E0", Offset = "0x145D7E0", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(TextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002D9C")]
		internal NullTextWriter() { }

		[Address(RVA = "0x145DCD0", Offset = "0x145CED0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D9D")]
		public virtual Encoding get_Encoding() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D9E")]
		public virtual void Write(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D9F")]
		public virtual void Write(string value) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DA2")]
		public virtual void Write(char value) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DA0")]
		public virtual void WriteLine() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DA1")]
		public virtual void WriteLine(string value) { }

	}

	[Token(Token = "0x200063B")]
	public sealed class SyncTextWriter : TextWriter, IDisposable
	{
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001940")]
		private readonly TextWriter _out; //Field offset: 0x30

		[Token(Token = "0x1700070D")]
		public virtual Encoding Encoding
		{
			[Address(RVA = "0x1468A90", Offset = "0x1467C90", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002DA4")]
			 get { } //Length: 42
		}

		[Token(Token = "0x1700070E")]
		public virtual IFormatProvider FormatProvider
		{
			[Address(RVA = "0x10AA0F0", Offset = "0x10A92F0", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002DA5")]
			 get { } //Length: 42
		}

		[Token(Token = "0x1700070F")]
		public virtual string NewLine
		{
			[Address(RVA = "0x1468AC0", Offset = "0x1467CC0", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6002DA6")]
			 get { } //Length: 42
		}

		[Address(RVA = "0x1468A00", Offset = "0x1467C00", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002DA3")]
		internal SyncTextWriter(TextWriter t) { }

		[Address(RVA = "0x10AA150", Offset = "0x10A9350", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DA7")]
		public virtual void Close() { }

		[Address(RVA = "0x14688E0", Offset = "0x1467AE0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002DA8")]
		protected virtual void Dispose(bool disposing) { }

		[Address(RVA = "0x1468940", Offset = "0x1467B40", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DA9")]
		public virtual void Flush() { }

		[Address(RVA = "0x1468A90", Offset = "0x1467C90", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DA4")]
		public virtual Encoding get_Encoding() { }

		[Address(RVA = "0x10AA0F0", Offset = "0x10A92F0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DA5")]
		public virtual IFormatProvider get_FormatProvider() { }

		[Address(RVA = "0x1468AC0", Offset = "0x1467CC0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DA6")]
		public virtual string get_NewLine() { }

		[Address(RVA = "0x13B2290", Offset = "0x13B1490", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DAA")]
		public virtual void Write(char value) { }

		[Address(RVA = "0x13B2410", Offset = "0x13B1610", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DAB")]
		public virtual void Write(Char[] buffer) { }

		[Address(RVA = "0x14689D0", Offset = "0x1467BD0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002DAC")]
		public virtual void Write(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x13B4060", Offset = "0x13B3260", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DAD")]
		public virtual void Write(string value) { }

		[Address(RVA = "0x13B2470", Offset = "0x13B1670", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DAE")]
		public virtual void Write(object value) { }

		[Address(RVA = "0x14689A0", Offset = "0x1467BA0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002DAF")]
		public virtual void WriteLine() { }

		[Address(RVA = "0x13B24A0", Offset = "0x13B16A0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002DB0")]
		public virtual void WriteLine(string value) { }

		[Address(RVA = "0x1468970", Offset = "0x1467B70", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002DB1")]
		public virtual void WriteLine(string format, object arg0) { }

	}

	[Token(Token = "0x400193B")]
	public static readonly TextWriter Null; //Field offset: 0x0
	[Token(Token = "0x400193C")]
	private static readonly Char[] s_coreNewLine; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400193D")]
	protected Char[] CoreNewLine; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400193E")]
	private string CoreNewLineStr; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400193F")]
	private IFormatProvider _internalFormatProvider; //Field offset: 0x28

	[Token(Token = "0x1700070A")]
	public abstract Encoding Encoding
	{
		[Token(Token = "0x6002D90")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000709")]
	public override IFormatProvider FormatProvider
	{
		[Address(RVA = "0x1469D50", Offset = "0x1468F50", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Token(Token = "0x6002D8B")]
		 get { } //Length: 87
	}

	[Token(Token = "0x1700070B")]
	public override string NewLine
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D91")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1469AE0", Offset = "0x1468CE0", Length = "0x123")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(TextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002D9B")]
	private static TextWriter() { }

	[Address(RVA = "0x1469C10", Offset = "0x1468E10", Length = "0x95")]
	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D89")]
	protected TextWriter() { }

	[Address(RVA = "0x1469CB0", Offset = "0x1468EB0", Length = "0x9E")]
	[CalledBy(Type = typeof(StringWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NullTextWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SyncTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(TextWriter))]
	[CalledBy(Type = typeof(TextWriter), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D8A")]
	protected TextWriter(IFormatProvider formatProvider) { }

	[Address(RVA = "0x1469460", Offset = "0x1468660", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D8C")]
	public override void Close() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D8D")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x14694D0", Offset = "0x14686D0", Length = "0x61")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IO.StreamFileUserDataBase", Member = "Close", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D8E")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D8F")]
	public override void Flush() { }

	[Token(Token = "0x6002D90")]
	public abstract Encoding get_Encoding() { }

	[Address(RVA = "0x1469D50", Offset = "0x1468F50", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Token(Token = "0x6002D8B")]
	public override IFormatProvider get_FormatProvider() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D91")]
	public override string get_NewLine() { }

	[Address(RVA = "0x1469540", Offset = "0x1468740", Length = "0x114")]
	[CalledBy(Type = typeof(Console), Member = "SetupStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Console), Member = "SetError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Console), Member = "SetOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnityLogWriter", Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D9A")]
	public static TextWriter Synchronized(TextWriter writer) { }

	[Address(RVA = "0x1469740", Offset = "0x1468940", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6002D96")]
	public override void Write(object value) { }

	[Address(RVA = "0x1469860", Offset = "0x1468A60", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D93")]
	public override void Write(Char[] buffer) { }

	[Address(RVA = "0x1469890", Offset = "0x1468A90", Length = "0x207")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D94")]
	public override void Write(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1469AA0", Offset = "0x1468CA0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D95")]
	public override void Write(string value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D92")]
	public override void Write(char value) { }

	[Address(RVA = "0x14696B0", Offset = "0x14688B0", Length = "0x18")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D97")]
	public override void WriteLine() { }

	[Address(RVA = "0x1469660", Offset = "0x1468860", Length = "0x41")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002D98")]
	public override void WriteLine(string value) { }

	[Address(RVA = "0x14696D0", Offset = "0x14688D0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002D99")]
	public override void WriteLine(string format, object arg0) { }

}

