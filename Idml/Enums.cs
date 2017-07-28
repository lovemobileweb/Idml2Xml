
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
public enum AddPageOptions
{
	EndOfStory,
	EndOfSection,
	EndOfDocument
}

public enum AdornmentOverprint
{
	Auto,
	OverprintOn,
	OverprintOff
}

public enum AlignmentStyleOptions
{
	Spreadsheet,
	LeftAlign,
	RightAlign,
	CenterAlign
}

public enum AlternateGlyphForms
{
	None,
	TraditionalForm,
	ExpertForm,
	JIS78Form,
	JIS83Form,
	MonospacedHalfWidthForm,
	ThirdWidthForm,
	QuarterWidthForm,
	NLCForm,
	ProportionalWidthForm,
	FullWidthForm,
	JIS04Form,
	JIS90Form
}

public enum AnchorPoint
{
	TopLeftAnchor,
	TopCenterAnchor,
	TopRightAnchor,
	LeftCenterAnchor,
	CenterAnchor,
	RightCenterAnchor,
	BottomLeftAnchor,
	BottomCenterAnchor,
	BottomRightAnchor
}

public enum AnchorPosition
{
	InlinePosition,
	AboveLine,
	Anchored
}

public enum AnchoredRelativeTo
{
	ColumnEdge,
	TextFrame,
	PageMargins,
	PageEdge,
	AnchorLocation
}

public enum AnimationEaseOptions
{
	NoEase,
	EaseIn,
	EaseOut,
	EaseInOut,
	CustomEase
}

public enum AnimationPlayOperations
{
	Play,
	Stop,
	Pause,
	Resume,
	ReversePlayback,
	StopAll
}

public enum ArrowHead
{
	None,
	SimpleArrowHead,
	SimpleWideArrowHead,
	TriangleArrowHead,
	TriangleWideArrowHead,
	BarbedArrowHead,
	CurvedArrowHead,
	CircleArrowHead,
	CircleSolidArrowHead,
	SquareArrowHead,
	SquareSolidArrowHead,
	BarArrowHead,
	PumpkinArrowHead
}

public enum AssignmentExportOptions
{
	EmptyFrames,
	AssignedSpreads,
	Everything
}

public enum AutoEnum
{
	AutoValue
}

public enum BalanceLinesStyle
{
	NoBalancing,
	VeeShape,
	FullyBalanced,
	PyramidShape
}

public enum BaselineFrameGridRelativeOption
{
	TopOfPage,
	TopOfMargin,
	TopOfFrame,
	TopOfInset
}

public enum BaselineGridRelativeOption
{
	TopOfPageOfBaselineGridRelativeOption,
	TopOfMarginOfBaselineGridRelativeOption
}

public enum BehaviorEvents
{
	MouseUp,
	MouseDown,
	MouseEnter,
	MouseExit,
	OnFocus,
	OnBlur
}

public enum BevelAndEmbossDirection
{
	Up,
	Down
}

public enum BevelAndEmbossStyle
{
	OuterBevel,
	InnerBevel,
	Emboss,
	PillowEmboss
}

public enum BevelAndEmbossTechnique
{
	SmoothContour,
	ChiselHard,
	ChiselSoft
}

public enum BlendMode
{
	Normal,
	Multiply,
	Screen,
	Overlay,
	SoftLight,
	HardLight,
	ColorDodge,
	ColorBurn,
	Darken,
	Lighten,
	Difference,
	Exclusion,
	Hue,
	Saturation,
	Color,
	Luminosity
}

public enum BlendingSpace
{
	Default,
	RGB,
	CMYK
}

public enum BookletTypeOptions
{
	TwoUpSaddleStitch,
	TwoUpPerfectBound,
	TwoUpConsecutive,
	ThreeUpConsecutive,
	FourUpConsecutive
}

public enum BuildingBlockTypes
{
	CustomStringBuildingBlock,
	FileNameBuildingBlock,
	ChapterNumberBuildingBlock,
	PageNumberBuildingBlock,
	FullParagraphBuildingBlock,
	ParagraphNumberBuildingBlock,
	ParagraphTextBuildingBlock,
	BookmarkNameBuildingBlock
}

public enum BulletCharacterType
{
	UnicodeOnly,
	UnicodeWithFont,
	GlyphWithFont
}

public enum BulletListExportOption
{
	UnorderedList,
	AsText
}

public enum Capitalization
{
	Normal,
	SmallCaps,
	AllCaps,
	CapToSmallCap
}

public enum ChangeCaseOptions
{
	None,
	Uppercase,
	Lowercase,
	Titlecase,
	Sentencecase
}

public enum ChangeTypes
{
	InsertedText,
	DeletedText,
	MovedText
}

public enum ChapterNumberSources
{
	UserDefined,
	ContinueFromPreviousDocument,
	SameAsPreviousDocument
}

public enum CharacterAlignment
{
	AlignBaseline,
	AlignEmTop,
	AlignEmCenter,
	AlignEmBottom,
	AlignICFTop,
	AlignICFBottom
}

public enum CharacterCountLocation
{
	None,
	TopAlign,
	LeftAlign,
	BottomAlign,
	RightAlign
}

public enum CharacterDirectionOptions
{
	DefaultDirection,
	LeftToRightDirection,
	RightToLeftDirection
}

public enum ClippingPathType
{
	None,
	DetectEdges,
	AlphaChannel,
	PhotoshopPath,
	UserModifiedPath
}

public enum ColorModel
{
	Spot,
	Process,
	Registration,
	Mixedinkmodel
}

public enum ColorOutputModes
{
	CompositeLeaveUnchanged,
	CompositeGray,
	CompositeRGB,
	CompositeCMYK,
	Separations,
	InRIPSeparations
}

public enum ColorOverride
{
	Normal,
	Specialpaper,
	Specialblack,
	Specialregistration,
	Hiddenreserved,
	Mixedinkparent
}

public enum ColorRenderingDictionary
{
	Default,
	UseDocument,
	Working
}

public enum ColorSettingsPolicy
{
	ColorPolicyOff,
	PreserveEmbeddedProfiles,
	ConvertToWorkingSpace,
	CombinationOfPreserveAndSafeCmyk
}

public enum ColorSpace
{
	RGB,
	CMYK,
	LAB,
	MixedInk,
	NoAlternateColor
}

public enum ComposeUsing
{
	UseUserDictionary,
	UseDocument,
	Both
}

public enum ConditionIndicatorMethod
{
	UseUnderline,
	UseHighlight
}

public enum ConditionIndicatorMode
{
	ShowIndicators,
	ShowAndPrintIndicators,
	HideIndicators
}

public enum ConditionUnderlineIndicatorAppearance
{
	Wavy,
	Solid,
	Dashed
}

public enum ContentType
{
	Unassigned,
	GraphicType,
	TextType
}

public enum ContentsTypeSettings
{
	AxialShade,
	RadialShade,
	MeshShade,
	ConstantShade
}

public enum ContourOptionsTypes
{
	BoundingBox,
	PhotoshopPath,
	DetectEdges,
	AlphaChannel,
	GraphicFrame,
	SameAsClipping
}

public enum ConvertPageBreaks
{
	None,
	PageBreak,
	ColumnBreak
}

public enum ConvertTablesOptions
{
	UnformattedTable,
	UnformattedTabbedText
}

public enum CornerOptions
{
	None,
	RoundedCorner,
	InverseRoundedCorner,
	InsetCorner,
	BevelCorner,
	FancyCorner,
	PumpkinCorner
}

public enum CrossReferenceType
{
	SeeOrAlsoBracket,
	See,
	SeeAlso,
	SeeHerein,
	SeeAlsoHerein,
	CustomCrossReference,
	CustomCrossReferenceBefore,
	CustomCrossReferenceAfter
}

public enum DataFormat
{
	ASCII,
	Binary
}

public enum DataSourceType
{
	CommaSeparated,
	TabDelimited
}

public enum DesignOptions
{
	FromCurrentAppearance,
	ToCurrentAppearance,
	ToCurrentLocation
}

public enum DiacriticPositionOptions
{
	DefaultPosition,
	LoosePosition,
	MediumPosition,
	TightPosition,
	OpentypePosition
}

public enum DigitsTypeOptions
{
	DefaultDigits,
	ArabicDigits,
	HindiDigits,
	FarsiDigits,
	NativeDigits,
	FullFarsiDigits,
	ThaiDigits,
	LaoDigits,
	DevanagariDigits,
	BengaliDigits,
	GurmukhiDigits,
	GujaratiDigits,
	OriyaDigits,
	TamilDigits,
	TeluguDigits,
	KannadaDigits,
	MalayalamDigits,
	TibetanDigits,
	KhmerDigits,
	BurmeseDigits
}

public enum DisplayOrderOptions
{
	OrderByRows,
	OrderByColumns
}

public enum DisplaySettingOptions
{
	HighQuality,
	Typical,
	Optimized,
	Default
}

public enum DocumentIntentOptions
{
	PrintIntent,
	WebIntent
}

public enum DynamicTriggerEvents
{
	OnPageLoad,
	OnPageClick,
	OnStateLoad,
	OnClick,
	OnRollover,
	OnRelease,
	OnRolloff,
	OnSelfClick,
	OnSelfRollover
}

public enum EmptyFrameFittingOptions
{
	None,
	ContentToFrame,
	Proportionally,
	FillProportionally
}

public enum EncodingType
{
	HexEncoding,
	Ascii85Encoding,
	Ascii64Encoding
}

public enum EndCap
{
	ButtEndCap,
	RoundEndCap,
	ProjectingEndCap
}

public enum EndJoin
{
	MiterEndJoin,
	RoundEndJoin,
	BevelEndJoin
}

public enum EpubCover
{
	None,
	FirstPage,
	ExternalImage
}

public enum ExportOrder
{
	LayoutOrder,
	ArticlePanelOrder,
	XMLStructureOrder
}

public enum FeatherCornerType
{
	Sharp,
	Rounded,
	Diffusion
}

public enum FeatherMode
{
	None,
	Standard
}

public enum FirstBaseline
{
	AscentOffset,
	CapHeight,
	LeadingOffset,
	EmboxHeight,
	XHeight,
	FixedHeight
}

public enum Fitting
{
	Proportional,
	FitContentToFrame,
	FitFrameToContent,
	PreserveSizes,
	FillProportional
}

public enum FlattenerLevel
{
	Low,
	MediumLow,
	Medium,
	MediumHigh,
	High
}

public enum FlipValues
{
	NotFlipped,
	Flipped,
	UndefinedFlipValue
}

public enum Flip
{
	None,
	Horizontal,
	Vertical,
	HorizontalAndVertical,
	Both
}

public enum FloatingWindowPosition
{
	UpperLeft,
	UpperMiddle,
	UpperRight,
	CenterLeft,
	Center,
	CenterRight,
	LowerLeft,
	LowerMiddle,
	LowerRight
}

public enum FloatingWindowSize
{
	OneFifth,
	OneFourth,
	OneHalf,
	Full,
	Double,
	Triple,
	Quadruple,
	Max
}

public enum FollowShapeModeOptions
{
	None,
	LeadingEdge,
	AllEdges
}

public enum FontDownloading
{
	None,
	Complete,
	Subset,
	SubsetLarge
}

public enum FontStatus
{
	Installed,
	NotAvailable,
	Fauxed,
	Substituted,
	Unknown
}

public enum FontTypes
{
	Type1,
	TrueType,
	CID,
	ATC,
	Bitmap,
	OCF,
	OpenTypeCFF,
	OpenTypeCID,
	OpenTypeTT,
	Unknown
}

public enum FootnoteFirstBaseline
{
	AscentOffset,
	CapHeight,
	LeadingOffset,
	EmboxHeight,
	XHeight,
	FixedHeight
}

public enum FootnoteMarkerPositioning
{
	NormalMarker,
	SuperscriptMarker,
	SubscriptMarker,
	RubyMarker
}

public enum FootnoteNumberingStyle
{
	UpperRoman,
	LowerRoman,
	UpperLetters,
	LowerLetters,
	Arabic,
	Symbols,
	Kanji,
	FullWidthArabic,
	SingleLeadingZeros,
	DoubleLeadingZeros,
	Asterisks,
	ArabicAlifBaTah,
	ArabicAbjad,
	HebrewBiblical,
	HebrewNonStandard
}

public enum FootnotePrefixSuffix
{
	NoPrefixSuffix,
	PrefixSuffixReference,
	PrefixSuffixMarker,
	PrefixSuffixBoth
}

public enum FootnoteRestarting
{
	DontRestart,
	PageRestart,
	SpreadRestart,
	SectionRestart
}

public enum FrameTypes
{
	TextFrameType,
	FrameGridType,
	Unknown
}

public enum GIFOptionsPalette
{
	AdaptivePalette,
	MacintoshPalette,
	WebPalette,
	WindowsPalette
}

public enum GlowTechnique
{
	Softer,
	Precise
}

public enum GoToZoomOptions
{
	InheritZoom,
	FitWindow,
	FitWidth,
	FitVisible,
	ActualSize
}

public enum GradientType
{
	Linear,
	Radial
}

public enum GridAlignment
{
	None,
	AlignBaseline,
	AlignEmTop,
	AlignEmCenter,
	AlignEmBottom,
	AlignICFTop,
	AlignICFBottom
}

public enum GridStartingPointOptions
{
	TopOutside,
	TopInside,
	BottomOutside,
	BottomInside,
	CenterVertical,
	CenterHorizontal,
	CenterCompletely
}

public enum GridViewSettings
{
	GridViewEnum,
	ZnViewEnum,
	AlignViewEnum,
	GridAndZnViewEnum
}

public enum HeaderFooterBreakTypes
{
	InAllTextColumns,
	OncePerTextFrame,
	OncePerPage
}

public enum HeaderTypes
{
	BasicLatin,
	FinnishSwedish,
	DanishNorwegian,
	Spanish,
	Croatian,
	Czech,
	Estonian,
	Hungarian,
	Latvian,
	Lithuanian,
	Polish,
	Romanian,
	Slovak,
	Slovenian,
	Turkish,
	Belarusian,
	Bulgarian,
	Russian,
	Ukrainian,
	KoreanConsonant,
	KoreanConsonantPlusVowel,
	HiraganaAll,
	HiraganaConsonantsOnly,
	KatakanaAll,
	KatakanaConsonantsOnly,
	ChinesePinyin,
	ChineseStrokeCount
}

public enum HorizontalAlignment
{
	RightAlign,
	LeftAlign,
	CenterAlign,
	TextAlign
}

public enum HorizontalOrVertical
{
	Horizontal,
	Vertical
}

public enum HyperlinkAppearanceHighlight
{
	None,
	Invert,
	Outline,
	Inset
}

public enum HyperlinkAppearanceStyle
{
	Solid,
	Dashed
}

public enum HyperlinkAppearanceWidth
{
	Thin,
	Medium,
	Thick
}

public enum HyperlinkDestinationPageSetting
{
	Fixed,
	FitView,
	FitWindow,
	FitWidth,
	FitHeight,
	FitVisible,
	InheritZoom
}

public enum ImageAlignmentType
{
	AlignLeft,
	AlignCenter,
	AlignRight
}

public enum ImageConversion
{
	Automatic,
	JPEG,
	GIF,
	PNG
}

public enum ImageDataTypes
{
	AllImageData,
	OptimizedSubsampling,
	ProxyImageData,
	None
}

public enum ImageExportOption
{
	OriginalImage,
	OptimizedImage,
	LinkToServer
}

public enum ImageFormat
{
	JPEG,
	GIF,
	PNG
}

public enum ImagePageBreakType
{
	PageBreakBefore,
	PageBreakAfter,
	PageBreakBeforeAndAfter
}

public enum ImageResolution
{
	Ppi72,
	Ppi96,
	Ppi150,
	Ppi300
}

public enum ImageSizeOption
{
	SizeFixed,
	SizeRelativeToPageWidth
}

public enum ImportPlatform
{
	Macintosh,
	PC
}

public enum ImportedPageCropOptions
{
	CropContent,
	CropBleed,
	CropSlug
}

public enum InCopyUIColors
{
	Canary,
	Lemon,
	Electrolyte,
	Lime,
	Forest,
	Lichen,
	Jade,
	Aqua,
	Cirrus,
	Ether,
	Slate,
	Ultramarine,
	Midnight,
	Blueberry,
	Eggplant,
	Grape,
	Fuchsia,
	Iris,
	Carnation,
	Mocha,
	Wheat,
	Mustard,
	Amber,
	Cornstarch,
	Powder,
	Smoke,
	Graphite,
	Gunmetal,
	LightBlue,
	Red,
	Green,
	Blue,
	Yellow,
	Magenta,
	Cyan,
	Gray,
	Black,
	Orange,
	DarkGreen,
	Teal,
	Tan,
	Brown,
	Violet,
	Gold,
	DarkBlue,
	Pink,
	Lavender,
	BrickRed,
	OliveGreen,
	Peach,
	Burgundy,
	GrassGreen,
	Ochre,
	Purple,
	LightGray,
	Charcoal,
	GridBlue,
	GridOrange,
	Fiesta,
	LightOlive,
	Lipstick,
	CuteTeal,
	Sulphur,
	GridGreen,
	White
}

public enum IndexFormat
{
	RuninFormat,
	NestedFormat
}

public enum InkTypes
{
	Normal,
	Opaque,
	Transparent,
	OpaqueIgnore
}

public enum InnerGlowSource
{
	CenterSourced,
	EdgeSourced
}

public enum JPEGOptionsFormat
{
	BaselineEncoding,
	ProgressiveEncoding
}

public enum JPEGOptionsQuality
{
	Low,
	Medium,
	High,
	Maximum
}

public enum Justification
{
	LeftAlign,
	CenterAlign,
	RightAlign,
	LeftJustified,
	RightJustified,
	CenterJustified,
	FullyJustified,
	ToBindingSide,
	AwayFromBindingSide
}

public enum KashidasOptions
{
	DefaultKashidas,
	KashidasOff
}

public enum KentenAlignment
{
	AlignKentenLeft,
	AlignKentenCenter
}

public enum KentenCharacterSet
{
	CharacterInput,
	ShiftJIS,
	JIS,
	Kuten,
	Unicode
}

public enum KentenCharacter
{
	None,
	KentenSesameDot,
	KentenWhiteSesameDot,
	KentenBlackCircle,
	KentenWhiteCircle,
	KentenBlackTriangle,
	KentenWhiteTriangle,
	KentenBullseye,
	KentenFisheye,
	KentenSmallBlackCircle,
	KentenSmallWhiteCircle,
	Custom
}

public enum KinsokuHangTypes
{
	None,
	KinsokuHangRegular,
	KinsokuHangForce
}

public enum KinsokuSet
{
	Nothing,
	HardKinsoku,
	SoftKinsoku,
	KoreanKinsoku,
	SimplifiedChineseKinsoku,
	TraditionalChineseKinsoku
}

public enum KinsokuType
{
	KinsokuPushInFirst,
	KinsokuPushOutFirst,
	KinsokuPushOutOnly,
	KinsokuPrioritizeAdjustmentAmount
}

public enum LeadingModel
{
	LeadingModelRoman,
	LeadingModelAkiBelow,
	LeadingModelAkiAbove,
	LeadingModelCenter,
	LeadingModelCenterDown
}

public enum Leading
{
	Auto
}

public enum LineAlignment
{
	LeftOrTopLineAlign,
	CenterLineAlign,
	RightOrBottomLineAlign,
	LeftOrTopLineJustify,
	CenterLineJustify,
	RightOrBottomLineJustify,
	FullLineJustify
}

public enum LinkExportPolicy
{
	NoAutoExport,
	ExportOnModify,
	ExportOnClose,
	ExportOnSave
}

public enum LinkImportPolicy
{
	NoAutoImport,
	ImportOnModify
}

public enum LinkResourceStoreState
{
	Normal,
	Cached,
	Contained,
	Embedded
}

public enum ListAlignment
{
	LeftAlign,
	CenterAlign,
	RightAlign
}

public enum ListType
{
	NoList,
	BulletList,
	NumberedList
}

public enum LockStateValues
{
	None,
	UnmanagedStory,
	CheckedInStory,
	CheckedOutStory,
	LockedStory,
	EmbeddedStory,
	MissingLockState,
	MixedLockState
}

public enum MarkLineWeight
{
	P125pt,
	P25pt,
	P50pt,
	P05mm,
	P07mm,
	P10mm,
	P15mm,
	P20mm,
	P30mm
}

public enum MarkTypes
{
	Default,
	JMarkWithCircle,
	JMarkWithoutCircle
}

public enum MeasurementUnits
{
	Points,
	Picas,
	Inches,
	InchesDecimal,
	Millimeters,
	Centimeters,
	Ciceros,
	Custom,
	Agates,
	U,
	Bai,
	Mils,
	Pixels,
	Q,
	Ha,
	AmericanPoints
}

public enum MojikumiTableDefaults
{
	Nothing,
	LineEndAllOneHalfEmEnum,
	OneEmIndentLineEndUkeOneHalfEmEnum,
	OneOrOneHalfEmIndentLineEndUkeOneHalfEmEnum,
	OneOrOneHalfEmIndentLineEndAllOneEmEnum,
	OneEmIndentLineEndAllOneEmEnum,
	OneEmIndentLineEndAllNoFloatEnum,
	OneEmIndentLineEndUkeNoFloatEnum,
	OneOrOneHalfEmIndentLineEndUkeNoFloatEnum,
	OneEmIndentLineEndAllOneHalfEmEnum,
	LineEndAllOneEmEnum,
	LineEndUkeNoFloatEnum,
	OneOrOneHalfEmIndentLineEndPeriodOneEmEnum,
	OneEmIndentLineEndPeriodOneEmEnum,
	LineEndPeriodOneEmEnum,
	TradChineseDefault,
	SimpChineseDefault
}

public enum MoviePlayOperations
{
	Play,
	PlayFromNavigationPoint,
	Stop,
	Pause,
	Resume,
	StopAll
}

public enum NestedStyleDelimiters
{
	Sentence,
	AnyWord,
	AnyCharacter,
	Letters,
	Digits,
	Tabs,
	InlineGraphic,
	Dropcap,
	ForcedLineBreak,
	EndNestedStyle,
	IndentHereTab,
	EmSpace,
	EnSpace,
	NonbreakingSpace,
	AutoPageNumber,
	SectionMarker,
	Repeat
}

public enum NothingEnum
{
	Nothing
}

public enum NumberedListExportOption
{
	OrderedList,
	StaticOrderedList,
	AsText
}

public enum NumberedParagraphsOptions
{
	IncludeFullParagraph,
	IncludeNumbersOnly,
	ExcludeNumbers
}

public enum NumberingStyle
{
	UpperRoman,
	LowerRoman,
	UpperLetters,
	LowerLetters,
	Arabic,
	Kanji,
	KatakanaModern,
	KatakanaTraditional,
	FormatNone,
	SingleLeadingZeros,
	ArabicAlifBaTah,
	ArabicAbjad,
	HebrewBiblical,
	HebrewNonStandard,
	DoubleLeadingZeros,
	TripleLeadingZeros
}

public enum OTFFigureStyle
{
	TabularLining,
	ProportionalOldstyle,
	ProportionalLining,
	TabularOldstyle,
	Default
}

public enum OutlineJoin
{
	MiterEndJoin,
	RoundEndJoin,
	BevelEndJoin
}

public enum PDFCrop
{
	CropArt,
	CropPDF,
	CropTrim,
	CropBleed,
	CropMedia,
	CropContentVisibleLayers,
	CropContentAllLayers,
	CropContent
}

public enum PPDValues
{
	DeviceIndependent
}

public enum PageBindingOptions
{
	Default,
	RightToLeft,
	LeftToRight
}

public enum PageColorOptions
{
	Nothing,
	UseMasterColor
}

public enum PageNumberPosition
{
	AfterEntry,
	BeforeEntry,
	None
}

public enum PageNumberStyle
{
	UpperRoman,
	LowerRoman,
	UpperLetters,
	LowerLetters,
	Arabic,
	Kanji,
	DoubleLeadingZeros,
	TripleLeadingZeros,
	ArabicAlifBaTah,
	ArabicAbjad,
	HebrewBiblical,
	HebrewNonStandard,
	SingleLeadingZeros,
	FullWidthArabic
}

public enum PageNumberTypes
{
	AutoPageNumber,
	NextPageNumber,
	PreviousPageNumber,
	TextVariable
}

public enum PagePositions
{
	UpperLeft,
	CenterHorizontally,
	CenterVertically,
	Centered
}

public enum PageRange
{
	AllPages,
	SelectedItems
}

public enum PageReferenceType
{
	CurrentPage,
	ToNextStyleChange,
	ToNextUseOfStyle,
	ToEndOfStory,
	ToEndOfDocument,
	ToEndOfSection,
	ForNextNParagraphs,
	ForNextNPages,
	SuppressPageNumbers
}

public enum PageTransitionDirectionOptions
{
	NotApplicable,
	Down,
	RightToLeft,
	LeftDown,
	LeftUp,
	LeftToRight,
	RightDown,
	RightUp,
	Up,
	In,
	Out,
	Horizontal,
	Vertical,
	HorizontalIn,
	HorizontalOut,
	VerticalIn,
	VerticalOut
}

public enum PageTransitionDurationOptions
{
	Fast,
	Medium,
	Slow
}

public enum PageTransitionTypeOptions
{
	None,
	BlindsTransition,
	BoxTransition,
	CombTransition,
	CoverTransition,
	DissolveTransition,
	FadeTransition,
	PageTurnTransition,
	PushTransition,
	SplitTransition,
	UncoverTransition,
	WipeTransition,
	ZoomInTransition,
	ZoomOutTransition
}

public enum PaperSize
{
	Auto
}

public enum PaperSizes
{
	DefinedByDriver,
	Custom
}

public enum ParagraphBreakTypes
{
	Anywhere,
	NextColumn,
	NextFrame,
	NextPage,
	NextOddPage,
	NextEvenPage
}

public enum ParagraphDirectionOptions
{
	LeftToRightDirection,
	RightToLeftDirection
}

public enum ParagraphJustificationOptions
{
	DefaultJustification,
	ArabicJustification,
	NaskhJustification
}

public enum PathTypeAlignments
{
	TopPathAlignment,
	BottomPathAlignment,
	CenterPathAlignment
}

public enum PlacedVectorProfilePolicy
{
	IgnoreAll,
	IgnoreOutputIntent,
	HonorAllProfiles
}

public enum PlayMode
{
	Once,
	StayOpen,
	RepeatPlay
}

public enum PlayOperations
{
	Play,
	Stop,
	Pause,
	Resume,
	StopAll
}

public enum Position
{
	Normal,
	Superscript,
	Subscript,
	OTSuperscript,
	OTSubscript,
	OTNumerator,
	OTDenominator
}

public enum PositionalForms
{
	None,
	Calculate,
	Initial,
	Medial,
	Final,
	Isolated
}

public enum PostScriptLevels
{
	Level2,
	Level3
}

public enum PreflightRuleFlag
{
	RuleIsDisabled,
	ReturnAsError,
	ReturnAsWarning,
	ReturnAsInformational
}

public enum PrintLayerOptions
{
	AllLayers,
	VisibleLayers,
	VisiblePrintableLayers
}

public enum PrintPageOrientation
{
	Portrait,
	Landscape,
	ReversePortrait,
	ReverseLandscape
}

public enum PrinterPresetTypes
{
	Default,
	Custom
}

public enum Printer
{
	PostscriptFile
}

public enum Profile
{
	PostScriptCMS,
	UseDocument,
	Working,
	NoCMS
}

public enum RenderingIntent
{
	UseColorSettings,
	Perceptual,
	Saturation,
	RelativeColorimetric,
	AbsoluteColorimetric
}

public enum ResolveStyleClash
{
	ResolveClashUseExisting,
	ResolveClashAutoRename,
	ResolveClashUseNew
}

public enum RestartPolicy
{
	AnyPreviousLevel,
	AfterSpecificLevel,
	RangeOfLevels
}

public enum RubyAlignments
{
	RubyLeft,
	RubyCenter,
	RubyRight,
	RubyFullJustify,
	RubyJIS,
	RubyEqualAki,
	Ruby1Aki
}

public enum RubyKentenPosition
{
	AboveRight,
	BelowLeft
}

public enum RubyOverhang
{
	None,
	RubyOverhangOneRuby,
	RubyOverhangHalfRuby,
	RubyOverhangOneChar,
	RubyOverhangHalfChar,
	RubyOverhangNoLimit
}

public enum RubyParentSpacing
{
	RubyParentNoAdjustment,
	RubyParentBothSides,
	RubyParent121Aki,
	RubyParentEqualAki,
	RubyParentFullJustify
}

public enum RubyTypes
{
	GroupRuby,
	PerCharacterRuby
}

public enum RuleDataType
{
	IntegerDataType,
	ShortIntegerDataType,
	RealDataType,
	StringDataType,
	BooleanDataType,
	ObjectDataType,
	ListDataType
}

public enum RuleWidth
{
	TextWidth,
	ColumnWidth
}

public enum RulerOrigin
{
	SpreadOrigin,
	PageOrigin,
	SpineOrigin
}

public enum ScaleModes
{
	ScaleWidthHeight,
	ScaleToFit
}

public enum Screeening
{
	Default,
	Custom
}

public enum SearchStrategies
{
	FirstOnPage,
	LastOnPage
}

public enum Sequences
{
	All,
	Odd,
	Even
}

public enum ShadowMode
{
	None,
	Drop
}

public enum SignatureSizeOptions
{
	SignatureSize4,
	SignatureSize8,
	SignatureSize12,
	SignatureSize16,
	SignatureSize32
}

public enum SingleWordJustification
{
	LeftAlign,
	CenterAlign,
	RightAlign,
	FullyJustified
}

public enum SourceSpaces
{
	UseDocument,
	ProofSpace
}

public enum SourceType
{
	SourceCustom,
	SourceXMPTitle,
	SourceXMPDescription,
	SourceXMPHeadline,
	SourceXMPOther,
	SourceXMLStructure
}

public enum SpaceUnitType
{
	CssEm,
	CssPixel
}

public enum SpanColumnCountOptions
{
	All
}

public enum SpanColumnTypeOptions
{
	SingleColumn,
	SpanColumns,
	SplitColumns
}

public enum SpecialCharacters
{
	AutoPageNumber,
	NextPageNumber,
	PreviousPageNumber,
	SectionMarker,
	BulletCharacter,
	CopyrightSymbol,
	DegreeSymbol,
	EllipsisCharacter,
	ForcedLineBreak,
	ParagraphSymbol,
	RegisteredTrademark,
	SectionSymbol,
	TrademarkSymbol,
	RightIndentTab,
	IndentHereTab,
	EmDash,
	EnDash,
	DiscretionaryHyphen,
	NonbreakingHyphen,
	EndNestedStyle,
	DoubleLeftQuote,
	DoubleRightQuote,
	SingleLeftQuote,
	SingleRightQuote,
	EmSpace,
	EnSpace,
	FlushSpace,
	HairSpace,
	NonbreakingSpace,
	ThinSpace,
	FigureSpace,
	PunctuationSpace,
	ColumnBreak,
	FrameBreak,
	PageBreak,
	OddPageBreak,
	EvenPageBreak,
	FootnoteSymbol,
	LeftToRightEmbedding,
	RightToLeftEmbedding,
	PopDirectionalFormatting,
	LeftToRightOverride,
	RightToLeftOverride,
	DottedCircle,
	ZeroWidthJoiner,
	TextVariable,
	SingleStraightQuote,
	DoubleStraightQuote,
	DiscretionaryLineBreak,
	ZeroWidthNonjoiner,
	ThirdSpace,
	QuarterSpace,
	SixthSpace,
	FixedWidthNonbreakingSpace,
	HebrewMaqaf,
	HebrewGeresh,
	HebrewGershayim,
	ArabicKashida,
	ArabicComma,
	ArabicSemicolon,
	ArabicQuestionMark,
	LeftToRightMark,
	RightToLeftMark,
	HebrewSofPasuk
}

public enum SpreadFlattenerLevel
{
	Default,
	None,
	Custom
}

public enum StartParagraph
{
	Anywhere,
	NextColumn,
	NextFrame,
	NextPage,
	NextOddPage,
	NextEvenPage
}

public enum StateTypes
{
	Up,
	Rollover,
	Down
}

public enum StoryDirectionOptions
{
	LeftToRightDirection,
	RightToLeftDirection,
	UnknownDirection
}

public enum StoryHorizontalOrVertical
{
	Horizontal,
	Vertical,
	Unknown
}

public enum StrokeAlignment
{
	CenterAlignment,
	InsideAlignment,
	OutsideAlignment
}

public enum StrokeCornerAdjustment
{
	None,
	Dashes,
	Gaps,
	DashesAndGaps
}

public enum StrokeOrderTypes
{
	RowOnTop,
	ColumnOnTop,
	BestJoins,
	Indesign2Compatibility
}

public enum StyleSheetExportOption
{
	None,
	EmbeddedCSS,
	StyleNameOnly,
	ExternalCSS
}

public enum TabStopAlignment
{
	LeftAlign,
	CenterAlign,
	RightAlign,
	CharacterAlign
}

public enum TableDirectionOptions
{
	LeftToRightDirection,
	RightToLeftDirection
}

public enum TableFormattingOptions
{
	ExcelFormattedTable,
	ExcelUnformattedTable,
	ExcelUnformattedTabbedText,
	ExcelFormatOnlyOnce
}

public enum TagType
{
	TagFromStructure,
	TagArtifact,
	TagBasedOnObject
}

public enum TaggedPDFStructureOrderOptions
{
	UseXMLStructure,
	UseArticles
}

public enum TextImportCharacterSet
{
	Ansi,
	RecommendShiftJIS83pv,
	ShiftJIS90pv,
	ShiftJIS90ms,
	GB2312,
	ChineseBig5,
	MacintoshCE,
	MacintoshCyrillic,
	MacintoshGreek,
	MacintoshTurkish,
	WindowsCyrillic,
	WindowsEE,
	WindowsGreek,
	WindowsTurkish,
	GB18030,
	KSC5601,
	WindowsBaltic,
	WindowsCE,
	MacintoshRoman,
	MacintoshCroatian,
	MacintoshIcelandic,
	MacintoshRomanian,
	CyrillicKOI8R,
	CyrillicKOI8U,
	CyrillicCP855,
	DOSLatin2,
	CyrillicISO,
	GreekISO,
	CentralEuropeanISO,
	TurkishISO,
	UTF16,
	UTF8
}

public enum TextPathEffects
{
	RainbowPathEffect,
	SkewPathEffect,
	RibbonPathEffect,
	StairStepPathEffect,
	GravityPathEffect
}

public enum TextStrokeAlign
{
	CenterAlignment,
	OutsideAlignment
}

public enum TextTypeAlignments
{
	AscenderTextAlignment,
	DescenderTextAlignment,
	CenterTextAlignment,
	BaselineTextAlignment,
	AboveRightEmBoxTextAlignment,
	BelowLeftEmBoxTextAlignment,
	AboveRightIcfBoxTextAlignment,
	BelowLeftIcfBoxTextAlignment
}

public enum TextWrapModes
{
	None,
	JumpObjectTextWrap,
	NextColumnTextWrap,
	BoundingBoxTextWrap,
	Contour
}

public enum TextWrapSideOptions
{
	BothSides,
	LeftSide,
	RightSide,
	SideTowardsSpine,
	SideAwayFromSpine,
	LargestArea
}

public enum ThumbsPerPage
{
	K1x2,
	K2x2,
	K3x3,
	K4x4,
	K5x5,
	K6x6,
	K7x7
}

public enum TilingTypes
{
	Auto,
	AutoJustified,
	Manual
}

public enum TrapEndTypes
{
	MiterTrapEnds,
	OverlapTrapEnds
}

public enum TrapImagePlacementTypes
{
	CenterEdges,
	Choke,
	ImageNeutralDensity,
	ImagesOverSpread
}

public enum Trapping
{
	Off,
	ApplicationBuiltin,
	AdobeInRIP
}

public enum UIColors
{
	LightBlue,
	Red,
	Green,
	Blue,
	Yellow,
	Magenta,
	Cyan,
	Gray,
	Black,
	Orange,
	DarkGreen,
	Teal,
	Tan,
	Brown,
	Violet,
	Gold,
	DarkBlue,
	Pink,
	Lavender,
	BrickRed,
	OliveGreen,
	Peach,
	Burgundy,
	GrassGreen,
	Ochre,
	Purple,
	LightGray,
	Charcoal,
	GridBlue,
	GridOrange,
	Fiesta,
	LightOlive,
	Lipstick,
	CuteTeal,
	Sulphur,
	GridGreen,
	White
}

public enum UpdateLinkOptions
{
	Unknown,
	ApplicationSettings,
	KeepOverrides
}

public enum VariableNumberingStyles
{
	Current,
	Arabic,
	UpperRoman,
	LowerRoman,
	UpperLetters,
	LowerLetters,
	Kanji,
	FullWidthArabic,
	SingleLeadingZeros,
	DoubleLeadingZeros
}

public enum VariableScopes
{
	DocumentScope,
	SectionScope
}

public enum VariableTypes
{
	CustomTextType,
	FileNameType,
	LastPageNumberType,
	ChapterNumberType,
	OutputDateType,
	CreationDateType,
	ModificationDateType,
	MatchCharacterStyleType,
	MatchParagraphStyleType,
	XrefPageNumberType,
	XrefChapterNumberType,
	LiveCaptionType
}

public enum VerticalAlignment
{
	TopAlign,
	BottomAlign,
	CenterAlign
}

public enum VerticalJustification
{
	TopAlign,
	CenterAlign,
	BottomAlign,
	JustifyAlign
}

public enum VerticallyRelativeTo
{
	ColumnEdge,
	TextFrame,
	PageMargins,
	PageEdge,
	LineBaseline,
	LineXheight,
	LineAscent,
	Capheight,
	TopOfLeading,
	EmboxTop,
	EmboxMiddle,
	EmboxBottom
}

public enum ViewZoomStyle
{
	FullScreen,
	ZoomIn,
	ZoomOut,
	FitPage,
	ActualSize,
	FitWidth,
	FitVisible,
	SinglePage,
	OneColumn,
	TwoColumn
}

public enum VisibilityInPdf
{
	VisibleInPdf,
	HiddenInPdf,
	VisibleButDoesNotPrintInPdf,
	HiddenButPrintableInPdf
}

public enum WarichuAlignment
{
	Auto,
	LeftAlign,
	CenterAlign,
	RightAlign,
	FullyJustified,
	LeftJustified,
	CenterJustified,
	RightJustified
}

public enum WatermarkHorizontalPositionEnum
{
	WatermarkHLeft,
	WatermarkHCenter,
	WatermarkHRight
}

public enum WatermarkVerticalPositionEnum
{
	WatermarkVTop,
	WatermarkVCenter,
	WatermarkVBottom
}

public enum XMLExportUntaggedTablesFormat
{
	None,
	CALS
}

public enum XMLFileEncoding
{
	UTF8,
	UTF16,
	ShiftJIS
}

public enum XMLImportStyles
{
	AppendImport,
	MergeImport
}

public enum XMLTransformFile
{
	StylesheetInXML
}


//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
