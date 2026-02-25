namespace Polytoria.Datamodel.Services;

[Token(Token = "0x200038A")]
public class ScriptService : Instance
{
	[CompilerGenerated]
	[Token(Token = "0x200038B")]
	private sealed class <>c
	{
		[Token(Token = "0x4000F75")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000F76")]
		public static Func<Instance, InstanceProxy> <>9__5_0; //Field offset: 0x8
		[Token(Token = "0x4000F77")]
		public static Func<DynamicInstance, DynamicInstanceProxy> <>9__5_1; //Field offset: 0x10
		[Token(Token = "0x4000F78")]
		public static Func<Part, PartProxy> <>9__5_2; //Field offset: 0x18
		[Token(Token = "0x4000F79")]
		public static Func<Game, GameProxy> <>9__5_3; //Field offset: 0x20
		[Token(Token = "0x4000F7A")]
		public static Func<BaseScript, BaseScriptProxy> <>9__5_4; //Field offset: 0x28
		[Token(Token = "0x4000F7B")]
		public static Func<ScriptInstance, ScriptInstanceProxy> <>9__5_5; //Field offset: 0x30
		[Token(Token = "0x4000F7C")]
		public static Func<LocalScript, LocalScriptProxy> <>9__5_6; //Field offset: 0x38
		[Token(Token = "0x4000F7D")]
		public static Func<ModuleScript, ModuleScriptProxy> <>9__5_7; //Field offset: 0x40
		[Token(Token = "0x4000F7E")]
		public static Func<RemoteEvent, RemoveEventProxy> <>9__5_8; //Field offset: 0x48
		[Token(Token = "0x4000F7F")]
		public static Func<Environment, EnvironmentProxy> <>9__5_9; //Field offset: 0x50
		[Token(Token = "0x4000F80")]
		public static Func<Player, PlayerProxy> <>9__5_10; //Field offset: 0x58
		[Token(Token = "0x4000F81")]
		public static Func<Players, PlayersProxy> <>9__5_11; //Field offset: 0x60
		[Token(Token = "0x4000F82")]
		public static Func<Text3D, Text3DProxy> <>9__5_12; //Field offset: 0x68
		[Token(Token = "0x4000F83")]
		public static Func<Sound, SoundProxy> <>9__5_13; //Field offset: 0x70
		[Token(Token = "0x4000F84")]
		public static Func<Tool, ToolProxy> <>9__5_14; //Field offset: 0x78
		[Token(Token = "0x4000F85")]
		public static Func<NPC, NPCProxy> <>9__5_15; //Field offset: 0x80
		[Token(Token = "0x4000F86")]
		public static Func<Spotlight, SpotlightProxy> <>9__5_16; //Field offset: 0x88
		[Token(Token = "0x4000F87")]
		public static Func<ValueBase, ValueBaseProxy> <>9__5_17; //Field offset: 0x90
		[Token(Token = "0x4000F88")]
		public static Func<BoolValue, BoolValueProxy> <>9__5_18; //Field offset: 0x98
		[Token(Token = "0x4000F89")]
		public static Func<ColorValue, ColorValueProxy> <>9__5_19; //Field offset: 0xA0
		[Token(Token = "0x4000F8A")]
		public static Func<StringValue, StringValueProxy> <>9__5_20; //Field offset: 0xA8
		[Token(Token = "0x4000F8B")]
		public static Func<InstanceValue, InstanceValueProxy> <>9__5_21; //Field offset: 0xB0
		[Token(Token = "0x4000F8C")]
		public static Func<IntValue, IntValueProxy> <>9__5_22; //Field offset: 0xB8
		[Token(Token = "0x4000F8D")]
		public static Func<NumberValue, NumberValueProxy> <>9__5_23; //Field offset: 0xC0
		[Token(Token = "0x4000F8E")]
		public static Func<Vector3Value, Vector3ValueProxy> <>9__5_24; //Field offset: 0xC8
		[Token(Token = "0x4000F8F")]
		public static Func<MeshPart, MeshPartProxy> <>9__5_25; //Field offset: 0xD0
		[Token(Token = "0x4000F90")]
		public static Func<BodyPosition, BodyPositionProxy> <>9__5_26; //Field offset: 0xD8
		[Token(Token = "0x4000F91")]
		public static Func<Backpack, BackpackProxy> <>9__5_27; //Field offset: 0xE0
		[Token(Token = "0x4000F92")]
		public static Func<Lighting, LightingProxy> <>9__5_28; //Field offset: 0xE8
		[Token(Token = "0x4000F93")]
		public static Func<SunLight, SunLightProxy> <>9__5_29; //Field offset: 0xF0
		[Token(Token = "0x4000F94")]
		public static Func<Climbable, ClimbableProxy> <>9__5_30; //Field offset: 0xF8
		[Token(Token = "0x4000F95")]
		public static Func<Decal, DecalProxy> <>9__5_31; //Field offset: 0x100
		[Token(Token = "0x4000F96")]
		public static Func<Particles, ParticlesProxy> <>9__5_32; //Field offset: 0x108
		[Token(Token = "0x4000F97")]
		public static Func<Hidden, HiddenProxy> <>9__5_33; //Field offset: 0x110
		[Token(Token = "0x4000F98")]
		public static Func<ServerHidden, ServerHiddenProxy> <>9__5_34; //Field offset: 0x118
		[Token(Token = "0x4000F99")]
		public static Func<Model, ModelProxy> <>9__5_35; //Field offset: 0x120
		[Token(Token = "0x4000F9A")]
		public static Func<PointLight, PointLightProxy> <>9__5_36; //Field offset: 0x128
		[Token(Token = "0x4000F9B")]
		public static Func<Truss, TrussProxy> <>9__5_37; //Field offset: 0x130
		[Token(Token = "0x4000F9C")]
		public static Func<Seat, SeatProxy> <>9__5_38; //Field offset: 0x138
		[Token(Token = "0x4000F9D")]
		public static Func<SkyBase, SkyBaseProxy> <>9__5_39; //Field offset: 0x140
		[Token(Token = "0x4000F9E")]
		public static Func<ImageSky, ImageSkyProxy> <>9__5_40; //Field offset: 0x148
		[Token(Token = "0x4000F9F")]
		public static Func<GradientSky, GradientSkyProxy> <>9__5_41; //Field offset: 0x150
		[Token(Token = "0x4000FA0")]
		public static Func<ProceduralSky, ProceduralSkyProxy> <>9__5_42; //Field offset: 0x158
		[Token(Token = "0x4000FA1")]
		public static Func<NetworkEvent, NetworkEventProxy> <>9__5_43; //Field offset: 0x160
		[Token(Token = "0x4000FA2")]
		public static Func<Signal, SignalProxy> <>9__5_44; //Field offset: 0x168
		[Token(Token = "0x4000FA3")]
		public static Func<PlayerDefaults, PlayerDefaultsProxy> <>9__5_45; //Field offset: 0x170
		[Token(Token = "0x4000FA4")]
		public static Func<GUI, GUIProxy> <>9__5_46; //Field offset: 0x178
		[Token(Token = "0x4000FA5")]
		public static Func<UIButton, UIButtonProxy> <>9__5_47; //Field offset: 0x180
		[Token(Token = "0x4000FA6")]
		public static Func<UIField, UIFieldProxy> <>9__5_48; //Field offset: 0x188
		[Token(Token = "0x4000FA7")]
		public static Func<UILabel, UILabelProxy> <>9__5_49; //Field offset: 0x190
		[Token(Token = "0x4000FA8")]
		public static Func<UITextInput, UITextInputProxy> <>9__5_50; //Field offset: 0x198
		[Token(Token = "0x4000FA9")]
		public static Func<UIView, UIViewProxy> <>9__5_51; //Field offset: 0x1A0
		[Token(Token = "0x4000FAA")]
		public static Func<UIImage, UIImageProxy> <>9__5_52; //Field offset: 0x1A8
		[Token(Token = "0x4000FAB")]
		public static Func<UIHVLayout, UIHVLayoutProxy> <>9__5_53; //Field offset: 0x1B0
		[Token(Token = "0x4000FAC")]
		public static Func<UIVerticalLayout, UIVerticalLayoutProxy> <>9__5_54; //Field offset: 0x1B8
		[Token(Token = "0x4000FAD")]
		public static Func<UIHorizontalLayout, UIHorizontalLayoutProxy> <>9__5_55; //Field offset: 0x1C0
		[Token(Token = "0x4000FAE")]
		public static Func<PlayerGUI, PlayerGUIProxy> <>9__5_56; //Field offset: 0x1C8
		[Token(Token = "0x4000FAF")]
		public static Func<Camera, CameraProxy> <>9__5_57; //Field offset: 0x1D0
		[Token(Token = "0x4000FB0")]
		public static Func<Datastore, DatastoreProxy> <>9__5_58; //Field offset: 0x1D8
		[Token(Token = "0x4000FB1")]
		public static Func<AchievementService, AchievementServiceProxy> <>9__5_59; //Field offset: 0x1E0
		[Token(Token = "0x4000FB2")]
		public static Func<PurchasesService, PurchasesServiceProxy> <>9__5_60; //Field offset: 0x1E8
		[Token(Token = "0x4000FB3")]
		public static Func<ChatService, ChatServiceProxy> <>9__5_61; //Field offset: 0x1F0
		[Token(Token = "0x4000FB4")]
		public static Func<CoreUIService, CoreUIServiceProxy> <>9__5_62; //Field offset: 0x1F8
		[Token(Token = "0x4000FB5")]
		public static Func<Datastore, DatastoreProxy> <>9__5_63; //Field offset: 0x200
		[Token(Token = "0x4000FB6")]
		public static Func<DataStoreService, DataStoreServiceProxy> <>9__5_64; //Field offset: 0x208
		[Token(Token = "0x4000FB7")]
		public static Func<FilterService, FilterServiceProxy> <>9__5_65; //Field offset: 0x210
		[Token(Token = "0x4000FB8")]
		public static Func<HttpService, HttpServiceProxy> <>9__5_66; //Field offset: 0x218
		[Token(Token = "0x4000FB9")]
		public static Func<InputService, InputServiceProxy> <>9__5_67; //Field offset: 0x220
		[Token(Token = "0x4000FBA")]
		public static Func<InsertService, InsertServiceProxy> <>9__5_68; //Field offset: 0x228
		[Token(Token = "0x4000FBB")]
		public static Func<TweenService, TweenServiceProxy> <>9__5_69; //Field offset: 0x230
		[Token(Token = "0x4000FBC")]
		public static Action<BaseScript> <>9__8_0; //Field offset: 0x238
		[Token(Token = "0x4000FBD")]
		public static Action<BaseScript> <>9__9_0; //Field offset: 0x240

		[Address(RVA = "0x4B5500", Offset = "0x4B4700", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002628")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002629")]
		public <>c() { }

		[Address(RVA = "0x4B2860", Offset = "0x4B1A60", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600262A")]
		internal InstanceProxy <Awake>b__5_0(Instance r) { }

		[Address(RVA = "0x4B2D90", Offset = "0x4B1F90", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600262B")]
		internal DynamicInstanceProxy <Awake>b__5_1(DynamicInstance r) { }

		[Address(RVA = "0x4B28C0", Offset = "0x4B1AC0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002634")]
		internal PlayerProxy <Awake>b__5_10(Player r) { }

		[Address(RVA = "0x4B2930", Offset = "0x4B1B30", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002635")]
		internal PlayersProxy <Awake>b__5_11(Players r) { }

		[Address(RVA = "0x4B29A0", Offset = "0x4B1BA0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002636")]
		internal Text3DProxy <Awake>b__5_12(Text3D r) { }

		[Address(RVA = "0x4B2A20", Offset = "0x4B1C20", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002637")]
		internal SoundProxy <Awake>b__5_13(Sound r) { }

		[Address(RVA = "0x4B2AA0", Offset = "0x4B1CA0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002638")]
		internal ToolProxy <Awake>b__5_14(Tool r) { }

		[Address(RVA = "0x4B2B20", Offset = "0x4B1D20", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002639")]
		internal NPCProxy <Awake>b__5_15(NPC r) { }

		[Address(RVA = "0x4B2BA0", Offset = "0x4B1DA0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600263A")]
		internal SpotlightProxy <Awake>b__5_16(Spotlight r) { }

		[Address(RVA = "0x4B2C20", Offset = "0x4B1E20", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600263B")]
		internal ValueBaseProxy <Awake>b__5_17(ValueBase r) { }

		[Address(RVA = "0x4B2C90", Offset = "0x4B1E90", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600263C")]
		internal BoolValueProxy <Awake>b__5_18(BoolValue r) { }

		[Address(RVA = "0x4B2D10", Offset = "0x4B1F10", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600263D")]
		internal ColorValueProxy <Awake>b__5_19(ColorValue r) { }

		[Address(RVA = "0x4B32E0", Offset = "0x4B24E0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600262C")]
		internal PartProxy <Awake>b__5_2(Part r) { }

		[Address(RVA = "0x4B2E00", Offset = "0x4B2000", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600263E")]
		internal StringValueProxy <Awake>b__5_20(StringValue r) { }

		[Address(RVA = "0x4B2E80", Offset = "0x4B2080", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600263F")]
		internal InstanceValueProxy <Awake>b__5_21(InstanceValue r) { }

		[Address(RVA = "0x4B2F00", Offset = "0x4B2100", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002640")]
		internal IntValueProxy <Awake>b__5_22(IntValue r) { }

		[Address(RVA = "0x4B2F80", Offset = "0x4B2180", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002641")]
		internal NumberValueProxy <Awake>b__5_23(NumberValue r) { }

		[Address(RVA = "0x4B3000", Offset = "0x4B2200", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002642")]
		internal Vector3ValueProxy <Awake>b__5_24(Vector3Value r) { }

		[Address(RVA = "0x4B3080", Offset = "0x4B2280", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002643")]
		internal MeshPartProxy <Awake>b__5_25(MeshPart r) { }

		[Address(RVA = "0x4B3110", Offset = "0x4B2310", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002644")]
		internal BodyPositionProxy <Awake>b__5_26(BodyPosition r) { }

		[Address(RVA = "0x4B3180", Offset = "0x4B2380", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002645")]
		internal BackpackProxy <Awake>b__5_27(Backpack r) { }

		[Address(RVA = "0x4B31F0", Offset = "0x4B23F0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002646")]
		internal LightingProxy <Awake>b__5_28(Lighting r) { }

		[Address(RVA = "0x4B3260", Offset = "0x4B2460", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002647")]
		internal SunLightProxy <Awake>b__5_29(SunLight r) { }

		[Address(RVA = "0x4B3870", Offset = "0x4B2A70", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600262D")]
		internal GameProxy <Awake>b__5_3(Game r) { }

		[Address(RVA = "0x4B3360", Offset = "0x4B2560", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002648")]
		internal ClimbableProxy <Awake>b__5_30(Climbable r) { }

		[Address(RVA = "0x4B33F0", Offset = "0x4B25F0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002649")]
		internal DecalProxy <Awake>b__5_31(Decal r) { }

		[Address(RVA = "0x4B3470", Offset = "0x4B2670", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600264A")]
		internal ParticlesProxy <Awake>b__5_32(Particles r) { }

		[Address(RVA = "0x4B34F0", Offset = "0x4B26F0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600264B")]
		internal HiddenProxy <Awake>b__5_33(Hidden r) { }

		[Address(RVA = "0x4B3560", Offset = "0x4B2760", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600264C")]
		internal ServerHiddenProxy <Awake>b__5_34(ServerHidden r) { }

		[Address(RVA = "0x4B35D0", Offset = "0x4B27D0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600264D")]
		internal ModelProxy <Awake>b__5_35(Model r) { }

		[Address(RVA = "0x4B3650", Offset = "0x4B2850", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600264E")]
		internal PointLightProxy <Awake>b__5_36(PointLight r) { }

		[Address(RVA = "0x4B36D0", Offset = "0x4B28D0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600264F")]
		internal TrussProxy <Awake>b__5_37(Truss r) { }

		[Address(RVA = "0x4B3770", Offset = "0x4B2970", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002650")]
		internal SeatProxy <Awake>b__5_38(Seat r) { }

		[Address(RVA = "0x4B3800", Offset = "0x4B2A00", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002651")]
		internal SkyBaseProxy <Awake>b__5_39(SkyBase r) { }

		[Address(RVA = "0x4B3DC0", Offset = "0x4B2FC0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600262E")]
		internal BaseScriptProxy <Awake>b__5_4(BaseScript r) { }

		[Address(RVA = "0x4B38E0", Offset = "0x4B2AE0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002652")]
		internal ImageSkyProxy <Awake>b__5_40(ImageSky r) { }

		[Address(RVA = "0x4B3960", Offset = "0x4B2B60", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002653")]
		internal GradientSkyProxy <Awake>b__5_41(GradientSky r) { }

		[Address(RVA = "0x4B39E0", Offset = "0x4B2BE0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002654")]
		internal ProceduralSkyProxy <Awake>b__5_42(ProceduralSky r) { }

		[Address(RVA = "0x4B3A60", Offset = "0x4B2C60", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002655")]
		internal NetworkEventProxy <Awake>b__5_43(NetworkEvent r) { }

		[Address(RVA = "0x4B3AD0", Offset = "0x4B2CD0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002656")]
		internal SignalProxy <Awake>b__5_44(Signal r) { }

		[Address(RVA = "0x4B3B40", Offset = "0x4B2D40", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002657")]
		internal PlayerDefaultsProxy <Awake>b__5_45(PlayerDefaults r) { }

		[Address(RVA = "0x4B3BB0", Offset = "0x4B2DB0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002658")]
		internal GUIProxy <Awake>b__5_46(GUI r) { }

		[Address(RVA = "0x4B3C20", Offset = "0x4B2E20", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002659")]
		internal UIButtonProxy <Awake>b__5_47(UIButton r) { }

		[Address(RVA = "0x4B3CC0", Offset = "0x4B2EC0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600265A")]
		internal UIFieldProxy <Awake>b__5_48(UIField r) { }

		[Address(RVA = "0x4B3D30", Offset = "0x4B2F30", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600265B")]
		internal UILabelProxy <Awake>b__5_49(UILabel r) { }

		[Address(RVA = "0x4B4310", Offset = "0x4B3510", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600262F")]
		internal ScriptInstanceProxy <Awake>b__5_5(ScriptInstance r) { }

		[Address(RVA = "0x4B3E30", Offset = "0x4B3030", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600265C")]
		internal UITextInputProxy <Awake>b__5_50(UITextInput r) { }

		[Address(RVA = "0x4B3EC0", Offset = "0x4B30C0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600265D")]
		internal UIViewProxy <Awake>b__5_51(UIView r) { }

		[Address(RVA = "0x4B3F40", Offset = "0x4B3140", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600265E")]
		internal UIImageProxy <Awake>b__5_52(UIImage r) { }

		[Address(RVA = "0x4B3FC0", Offset = "0x4B31C0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600265F")]
		internal UIHVLayoutProxy <Awake>b__5_53(UIHVLayout r) { }

		[Address(RVA = "0x4B4040", Offset = "0x4B3240", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002660")]
		internal UIVerticalLayoutProxy <Awake>b__5_54(UIVerticalLayout r) { }

		[Address(RVA = "0x4B40D0", Offset = "0x4B32D0", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002661")]
		internal UIHorizontalLayoutProxy <Awake>b__5_55(UIHorizontalLayout r) { }

		[Address(RVA = "0x4B4160", Offset = "0x4B3360", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002662")]
		internal PlayerGUIProxy <Awake>b__5_56(PlayerGUI r) { }

		[Address(RVA = "0x4B41D0", Offset = "0x4B33D0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002663")]
		internal CameraProxy <Awake>b__5_57(Camera r) { }

		[Address(RVA = "0x4B4250", Offset = "0x4B3450", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002664")]
		internal DatastoreProxy <Awake>b__5_58(Datastore r) { }

		[Address(RVA = "0x4B42B0", Offset = "0x4B34B0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002665")]
		internal AchievementServiceProxy <Awake>b__5_59(AchievementService r) { }

		[Address(RVA = "0x4B4750", Offset = "0x4B3950", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002630")]
		internal LocalScriptProxy <Awake>b__5_6(LocalScript r) { }

		[Address(RVA = "0x4B4390", Offset = "0x4B3590", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002666")]
		internal PurchasesServiceProxy <Awake>b__5_60(PurchasesService r) { }

		[Address(RVA = "0x4B43F0", Offset = "0x4B35F0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002667")]
		internal ChatServiceProxy <Awake>b__5_61(ChatService r) { }

		[Address(RVA = "0x4B4450", Offset = "0x4B3650", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002668")]
		internal CoreUIServiceProxy <Awake>b__5_62(CoreUIService r) { }

		[Address(RVA = "0x4B44B0", Offset = "0x4B36B0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002669")]
		internal DatastoreProxy <Awake>b__5_63(Datastore r) { }

		[Address(RVA = "0x4B4510", Offset = "0x4B3710", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600266A")]
		internal DataStoreServiceProxy <Awake>b__5_64(DataStoreService r) { }

		[Address(RVA = "0x4B4570", Offset = "0x4B3770", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600266B")]
		internal FilterServiceProxy <Awake>b__5_65(FilterService r) { }

		[Address(RVA = "0x4B45D0", Offset = "0x4B37D0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600266C")]
		internal HttpServiceProxy <Awake>b__5_66(HttpService r) { }

		[Address(RVA = "0x4B4630", Offset = "0x4B3830", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600266D")]
		internal InputServiceProxy <Awake>b__5_67(InputService r) { }

		[Address(RVA = "0x4B4690", Offset = "0x4B3890", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600266E")]
		internal InsertServiceProxy <Awake>b__5_68(InsertService r) { }

		[Address(RVA = "0x4B46F0", Offset = "0x4B38F0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600266F")]
		internal TweenServiceProxy <Awake>b__5_69(TweenService r) { }

		[Address(RVA = "0x4B47D0", Offset = "0x4B39D0", Length = "0x80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002631")]
		internal ModuleScriptProxy <Awake>b__5_7(ModuleScript r) { }

		[Address(RVA = "0x4B4850", Offset = "0x4B3A50", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002632")]
		internal RemoveEventProxy <Awake>b__5_8(RemoteEvent r) { }

		[Address(RVA = "0x4B48C0", Offset = "0x4B3AC0", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002633")]
		internal EnvironmentProxy <Awake>b__5_9(Environment r) { }

		[Address(RVA = "0x4B4930", Offset = "0x4B3B30", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseScript), Member = "Run", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002671")]
		internal void <RunLocalScripts>b__9_0(BaseScript s) { }

		[Address(RVA = "0x4B4930", Offset = "0x4B3B30", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BaseScript), Member = "Run", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002670")]
		internal void <RunScripts>b__8_0(BaseScript s) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200038C")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FBE")]
		public ScriptService <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000FBF")]
		public Script script; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002672")]
		public <>c__DisplayClass13_0() { }

		[Address(RVA = "0x4B4A30", Offset = "0x4B3C30", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScriptService), Member = "LuaPrint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002673")]
		internal void <RunScriptInstance>b__0(string s) { }

		[Address(RVA = "0x4B4A60", Offset = "0x4B3C60", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ScriptService), Member = "LuaRequire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModuleScript), typeof(Script)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002674")]
		internal DynValue <RunScriptInstance>b__1(ModuleScript ms) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200038D")]
	private sealed class <InvokeEvent>d__21 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FC0")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000FC1")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000FC2")]
		public DynValue func; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000FC3")]
		public ScriptService <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000FC4")]
		public Object[] par; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000FC5")]
		private DynValue <coroutine>5__2; //Field offset: 0x38

		[Token(Token = "0x17000B51")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002678")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000B52")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600267A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002675")]
		public <InvokeEvent>d__21(int <>1__state) { }

		[Address(RVA = "0x4AE610", Offset = "0x4AD810", Length = "0x212")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(DynValue), Member = "get_Function", ReturnType = typeof(Closure))]
		[Calls(Type = typeof(Script), Member = "CreateCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(DynValue), Member = "get_Coroutine", ReturnType = typeof(Coroutine))]
		[Calls(Type = typeof(Coroutine), Member = "set_AutoYieldCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Coroutine), Member = "get_State", ReturnType = typeof(CoroutineState))]
		[Calls(Type = typeof(ScriptService), Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(Object[])}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WaitForSeconds), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002677")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002678")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600267A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4AE830", Offset = "0x4ADA30", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6002679")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002676")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200038E")]
	private sealed class <RunScriptInstance>d__13 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000FC6")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000FC7")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000FC8")]
		public ScriptService <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000FC9")]
		public BaseScript scriptInstance; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000FCA")]
		private <>c__DisplayClass13_0 <>8__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000FCB")]
		private DynValue <coroutine>5__2; //Field offset: 0x38

		[Token(Token = "0x17000B53")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x600267E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000B54")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6002680")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
		[CallerCount(Count = 68)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600267B")]
		public <RunScriptInstance>d__13(int <>1__state) { }

		[Address(RVA = "0x4B0780", Offset = "0x4AF980", Length = "0x1C80")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Func`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Coroutine), Member = "get_State", ReturnType = typeof(CoroutineState))]
		[Calls(Type = typeof(Coroutine), Member = "set_AutoYieldCounter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DynValue), Member = "get_Coroutine", ReturnType = typeof(Coroutine))]
		[Calls(Type = typeof(Script), Member = "CreateCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(ScriptService), Member = "ExecuteScriptInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(BaseScript)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(System.Func`1<System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Table), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(DynValue)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UserData), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(Table), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Script), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CoreModules)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ScriptService), Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(Object[])}, ReturnType = typeof(DynValue))]
		[Calls(Type = typeof(WaitForSeconds), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600267D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600267E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6002680")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x4B2420", Offset = "0x4B1620", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x600267F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600267C")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x4000F71")]
	private static ScriptService <Instance>k__BackingField; //Field offset: 0x0
	[Token(Token = "0x4000F72")]
	public const string payload = "function wait(N)
coroutine.yield(N);
return os.time();
end"; //Field offset: 0x0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000F73")]
	private List<BaseScript> scripts; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000F74")]
	private List<BaseScript> scriptsLocal; //Field offset: 0x100

	[Token(Token = "0x17000B50")]
	public private static ScriptService Instance
	{
		[Address(RVA = "0x48F350", Offset = "0x48E550", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6002610")]
		 get { } //Length: 78
		[Address(RVA = "0x48F3A0", Offset = "0x48E5A0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6002611")]
		private set { } //Length: 105
	}

	[Address(RVA = "0x48F190", Offset = "0x48E390", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterRpc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002627")]
	private static ScriptService() { }

	[Address(RVA = "0x48F270", Offset = "0x48E470", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002623")]
	public ScriptService() { }

	[Address(RVA = "0x489300", Offset = "0x488500", Length = "0x49A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UserData), Member = "RegisterProxyType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TProxy", "TTarget"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<TTarget, TProxy>", typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(IUserDataDescriptor))]
	[Calls(Type = typeof(UserData), Member = "RegisterType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteropAccessMode), typeof(string)}, ReturnType = typeof(IUserDataDescriptor))]
	[CallsDeduplicatedMethods(Count = 70)]
	[Token(Token = "0x6002612")]
	protected virtual void Awake() { }

	[Address(RVA = "0x48DCB0", Offset = "0x48CEB0", Length = "0xCC")]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(DynValue), Member = "IsNilOrNan", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[MoonSharpHidden]
	[Token(Token = "0x600261F")]
	public void CallFunc(DynValue func, Object[] par) { }

	[Address(RVA = "0x48DD80", Offset = "0x48CF80", Length = "0x109")]
	[CalledBy(Type = typeof(ScriptService), Member = "RunLocalScripts", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptService), Member = "CheckForLocalScripts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(ScriptService), Member = "CheckForLocalScripts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002615")]
	private void CheckForLocalScripts(Instance parent) { }

	[Address(RVA = "0x48DE90", Offset = "0x48D090", Length = "0x109")]
	[CalledBy(Type = typeof(ScriptService), Member = "RunScripts", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptService), Member = "CheckForScripts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(ScriptService), Member = "CheckForScripts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002616")]
	private void CheckForScripts(Instance parent) { }

	[Address(RVA = "0x48DFA0", Offset = "0x48D1A0", Length = "0x23B")]
	[CalledBy(Type = typeof(<RunScriptInstance>d__13), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ScriptService), Member = "LuaPrint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Script), Member = "DoString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Instance), Member = "get_FullName", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x600261E")]
	private DynValue ExecuteScriptInstance(Script script, BaseScript s) { }

	[Address(RVA = "0x48E1E0", Offset = "0x48D3E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_timeSinceLevelLoad", ReturnType = typeof(float))]
	[Token(Token = "0x6002622")]
	private float GameTime() { }

	[Address(RVA = "0x48F350", Offset = "0x48E550", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6002610")]
	public static ScriptService get_Instance() { }

	[Address(RVA = "0x48E1F0", Offset = "0x48D3F0", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<InvokeEvent>d__21))]
	[MoonSharpHidden]
	[Token(Token = "0x6002620")]
	public IEnumerator InvokeEvent(DynValue func, Object[] par) { }

	[Address(RVA = "0x48E2A0", Offset = "0x48D4A0", Length = "0x177")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIController), Member = "DebugLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002626")]
	protected static void InvokeUserCode_RpcOnLuaPrintReceive__String__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x48E420", Offset = "0x48D620", Length = "0x2E0")]
	[CalledBy(Type = typeof(BaseScript), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseScript), Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c__DisplayClass13_0), Member = "<RunScriptInstance>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScriptService), Member = "ResumeScriptCoroutine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(string), typeof(Object[])}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ScriptService), Member = "ExecuteScriptInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(BaseScript)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(UIController), Member = "DebugLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Token(Token = "0x600261B")]
	public void LuaPrint(string message, bool error = false) { }

	[Address(RVA = "0x48E710", Offset = "0x48D910", Length = "0x63")]
	[CalledBy(Type = typeof(<>c__DisplayClass13_0), Member = "<RunScriptInstance>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModuleScript)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Instance), Member = "get_FullName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Script), Member = "DoString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Table), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600261A")]
	public DynValue LuaRequire(ModuleScript moduleScript, Script script) { }

	[Address(RVA = "0x48E780", Offset = "0x48D980", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B80")]
	[Calls(Type = typeof(ScriptService), Member = "CallFunc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynValue), typeof(Object[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6002619")]
	public void LuaSpawn(DynValue func) { }

	[Address(RVA = "0x48E7E0", Offset = "0x48D9E0", Length = "0x22A")]
	[CalledBy(Type = typeof(<InvokeEvent>d__21), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(<RunScriptInstance>d__13), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Coroutine), Member = "Resume", ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002BE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ScriptService), Member = "LuaPrint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Coroutine), Member = "Resume", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(Coroutine), Member = "get_State", ReturnType = typeof(CoroutineState))]
	[Calls(Type = typeof(DynValue), Member = "get_Coroutine", ReturnType = typeof(Coroutine))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x600261D")]
	private DynValue ResumeScriptCoroutine(DynValue coroutine, string identifier, Object[] par) { }

	[Address(RVA = "0x48EA10", Offset = "0x48DC10", Length = "0x182")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendRPCInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ClientRpc]
	[Token(Token = "0x600261C")]
	private void RpcOnLuaPrintReceive(string message, bool error) { }

	[Address(RVA = "0x48EBA0", Offset = "0x48DDA0", Length = "0x18D")]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<PostPlayerLoad>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptService), Member = "CheckForLocalScripts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[MoonSharpHidden]
	[Token(Token = "0x6002614")]
	public void RunLocalScripts() { }

	[Address(RVA = "0x48EDC0", Offset = "0x48DFC0", Length = "0xDD")]
	[CalledBy(Type = typeof(BaseScript), Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[MoonSharpHidden]
	[Token(Token = "0x6002617")]
	public void RunScript(BaseScript s) { }

	[Address(RVA = "0x48ED30", Offset = "0x48DF30", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(typeof(<RunScriptInstance>d__13))]
	[Token(Token = "0x6002618")]
	private IEnumerator RunScriptInstance(BaseScript scriptInstance) { }

	[Address(RVA = "0x48EEA0", Offset = "0x48E0A0", Length = "0x1A0")]
	[CalledBy(Type = typeof(GameIO), Member = "PostMapLoad", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptService), Member = "CheckForScripts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[MoonSharpHidden]
	[Token(Token = "0x6002613")]
	public void RunScripts() { }

	[Address(RVA = "0x48F3A0", Offset = "0x48E5A0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6002611")]
	private static void set_Instance(ScriptService value) { }

	[Address(RVA = "0x48F050", Offset = "0x48E250", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002621")]
	private float Tick() { }

	[Address(RVA = "0x48F110", Offset = "0x48E310", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIController), Member = "DebugLog", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002625")]
	protected void UserCode_RpcOnLuaPrintReceive__String__Boolean(string message, bool error) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002624")]
	public virtual bool Weaved() { }

}

