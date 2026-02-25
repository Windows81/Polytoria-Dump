namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x2000399")]
public class BodyPositionProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FE3")]
	private readonly BodyPosition bodyPosition; //Field offset: 0x18

	[Token(Token = "0x17000B58")]
	public float AcceptanceDistance
	{
		[Address(RVA = "0x4A1100", Offset = "0x4A0300", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60026AA")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1150", Offset = "0x4A0350", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026AB")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B57")]
	public float Force
	{
		[Address(RVA = "0x4A1100", Offset = "0x4A0300", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60026A8")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1150", Offset = "0x4A0350", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60026A9")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B56")]
	public Vector3 TargetPosition
	{
		[Address(RVA = "0x4A1120", Offset = "0x4A0320", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026A6")]
		 get { } //Length: 47
		[Address(RVA = "0x4A1170", Offset = "0x4A0370", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60026A7")]
		 set { } //Length: 53
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60026A5")]
	public BodyPositionProxy(BodyPosition target) { }

	[Address(RVA = "0x4A1100", Offset = "0x4A0300", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026AA")]
	public float get_AcceptanceDistance() { }

	[Address(RVA = "0x4A1100", Offset = "0x4A0300", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60026A8")]
	public float get_Force() { }

	[Address(RVA = "0x4A1120", Offset = "0x4A0320", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026A6")]
	public Vector3 get_TargetPosition() { }

	[Address(RVA = "0x4A1150", Offset = "0x4A0350", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026AB")]
	public void set_AcceptanceDistance(float value) { }

	[Address(RVA = "0x4A1150", Offset = "0x4A0350", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60026A9")]
	public void set_Force(float value) { }

	[Address(RVA = "0x4A1170", Offset = "0x4A0370", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026A7")]
	public void set_TargetPosition(Vector3 value) { }

}

