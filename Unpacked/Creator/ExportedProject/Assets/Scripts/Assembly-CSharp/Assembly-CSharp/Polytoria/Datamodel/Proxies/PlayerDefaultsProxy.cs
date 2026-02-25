namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B4")]
public class PlayerDefaultsProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000FFE")]
	private readonly PlayerDefaults playerDefaults; //Field offset: 0x18

	[Token(Token = "0x17000C06")]
	public Color ChatColor
	{
		[Address(RVA = "0x4A70C0", Offset = "0x4A62C0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002839")]
		 get { } //Length: 36
		[Address(RVA = "0x4A71D0", Offset = "0x4A63D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600283A")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C04")]
	public float JumpPower
	{
		[Address(RVA = "0x4A70F0", Offset = "0x4A62F0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002835")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7200", Offset = "0x4A6400", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002836")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BFD")]
	public float MaxHealth
	{
		[Address(RVA = "0x4A7110", Offset = "0x4A6310", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002827")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7220", Offset = "0x4A6420", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002828")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C02")]
	public float MaxStamina
	{
		[Address(RVA = "0x4A3DB0", Offset = "0x4A2FB0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002831")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7240", Offset = "0x4A6440", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002832")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C05")]
	public float RespawnTime
	{
		[Address(RVA = "0x4A7130", Offset = "0x4A6330", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002837")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7260", Offset = "0x4A6460", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002838")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BFF")]
	public float SprintSpeed
	{
		[Address(RVA = "0x4A7150", Offset = "0x4A6350", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600282B")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7280", Offset = "0x4A6480", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600282C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C01")]
	public float Stamina
	{
		[Address(RVA = "0x4A7190", Offset = "0x4A6390", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600282F")]
		 get { } //Length: 31
		[Address(RVA = "0x4A72E0", Offset = "0x4A64E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002830")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C00")]
	public bool StaminaEnabled
	{
		[Address(RVA = "0x4A7170", Offset = "0x4A6370", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600282D")]
		 get { } //Length: 30
		[Address(RVA = "0x4A72A0", Offset = "0x4A64A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600282E")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C03")]
	public float StaminaRegen
	{
		[Address(RVA = "0x4A3D90", Offset = "0x4A2F90", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002833")]
		 get { } //Length: 31
		[Address(RVA = "0x4A72C0", Offset = "0x4A64C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002834")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BFE")]
	public float WalkSpeed
	{
		[Address(RVA = "0x4A71B0", Offset = "0x4A63B0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002829")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7300", Offset = "0x4A6500", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600282A")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002826")]
	public PlayerDefaultsProxy(PlayerDefaults target) { }

	[Address(RVA = "0x4A70C0", Offset = "0x4A62C0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002839")]
	public Color get_ChatColor() { }

	[Address(RVA = "0x4A70F0", Offset = "0x4A62F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002835")]
	public float get_JumpPower() { }

	[Address(RVA = "0x4A7110", Offset = "0x4A6310", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002827")]
	public float get_MaxHealth() { }

	[Address(RVA = "0x4A3DB0", Offset = "0x4A2FB0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002831")]
	public float get_MaxStamina() { }

	[Address(RVA = "0x4A7130", Offset = "0x4A6330", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002837")]
	public float get_RespawnTime() { }

	[Address(RVA = "0x4A7150", Offset = "0x4A6350", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600282B")]
	public float get_SprintSpeed() { }

	[Address(RVA = "0x4A7190", Offset = "0x4A6390", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600282F")]
	public float get_Stamina() { }

	[Address(RVA = "0x4A7170", Offset = "0x4A6370", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600282D")]
	public bool get_StaminaEnabled() { }

	[Address(RVA = "0x4A3D90", Offset = "0x4A2F90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002833")]
	public float get_StaminaRegen() { }

	[Address(RVA = "0x4A71B0", Offset = "0x4A63B0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002829")]
	public float get_WalkSpeed() { }

	[Address(RVA = "0x4A71D0", Offset = "0x4A63D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600283A")]
	public void set_ChatColor(Color value) { }

	[Address(RVA = "0x4A7200", Offset = "0x4A6400", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002836")]
	public void set_JumpPower(float value) { }

	[Address(RVA = "0x4A7220", Offset = "0x4A6420", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002828")]
	public void set_MaxHealth(float value) { }

	[Address(RVA = "0x4A7240", Offset = "0x4A6440", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002832")]
	public void set_MaxStamina(float value) { }

	[Address(RVA = "0x4A7260", Offset = "0x4A6460", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002838")]
	public void set_RespawnTime(float value) { }

	[Address(RVA = "0x4A7280", Offset = "0x4A6480", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600282C")]
	public void set_SprintSpeed(float value) { }

	[Address(RVA = "0x4A72E0", Offset = "0x4A64E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002830")]
	public void set_Stamina(float value) { }

	[Address(RVA = "0x4A72A0", Offset = "0x4A64A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600282E")]
	public void set_StaminaEnabled(bool value) { }

	[Address(RVA = "0x4A72C0", Offset = "0x4A64C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002834")]
	public void set_StaminaRegen(float value) { }

	[Address(RVA = "0x4A7300", Offset = "0x4A6500", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600282A")]
	public void set_WalkSpeed(float value) { }

}

