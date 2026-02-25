namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x200039C")]
public class ClimbableProxy : PartProxy
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FE6")]
	private readonly Climbable climbable; //Field offset: 0x28

	[Token(Token = "0x17000B6F")]
	public float ClimbSpeed
	{
		[Address(RVA = "0x4A1860", Offset = "0x4A0A60", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026DA")]
		 get { } //Length: 31
		[Address(RVA = "0x4A1880", Offset = "0x4A0A80", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60026DB")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A17F0", Offset = "0x4A09F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60026D9")]
	public ClimbableProxy(Climbable target) { }

	[Address(RVA = "0x4A1860", Offset = "0x4A0A60", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026DA")]
	public float get_ClimbSpeed() { }

	[Address(RVA = "0x4A1880", Offset = "0x4A0A80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60026DB")]
	public void set_ClimbSpeed(float value) { }

}

