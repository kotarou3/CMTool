﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConceptMatrix.Utility
{
    [XmlRoot]
    public class Settings
    {
        #region Singleton
        [XmlIgnore]
        private static Settings instance;
        [XmlIgnore]
        public static Settings Instance
        {
            get
            {
                if (instance == null)
                    instance = new Settings();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        #endregion
        public string LastUpdated { get; set; }
        public string AoBOffset { get; set; }
        public string GposeOffset { get; set; }
        public string CameraOffset { get; set; }
        public string TimeOffset { get; set; }
        public string WeatherOffset { get; set; }
        public string TerritoryOffset { get; set; }
        public string TargetOffset { get; set; }
        public string GposeFilters { get; set; }
        public string MusicOffset { get; set; }
        public string SkeletonOffset { get; set; }
        public string SkeletonOffset2 { get; set; }
        public string SkeletonOffset3 { get; set; }
        public string CharacterRenderOffset { get; set; }
        public string CharacterRenderOffset2 { get; set; }
        public string GposeEntityOffset { get; set; }
        public CharacterOffsets Character { get; set; }
        public PositionOffsets Position { get; set; }
    }

    [Serializable]
    public struct CharacterOffsets
    {
        public string AltCheckPlayerFrozen { get; set; }
        public string EmoteIsPlayerFrozen { get; set; }
        public string CharacterRender { get; set; }
        public string HDR { get; set; }
        public string Brightness { get; set; }
        public string Contrast { get; set; }
        public string FilterEnable { get; set; }
        public string FilterAoB { get; set; }
        public string Exposure { get; set; }
        public string Filmic { get; set; }
        public string SHDR { get; set; }
        public string Colorfulness { get; set; }
        public string Contrast2 { get; set; }
        public string Colorfulnesss2 { get; set; }
        public string Gamma { get; set; }
        public string Vibrance { get; set; }
        public string GBlue { get; set; }
        public string GGreens { get; set; }
        public string GRed { get; set; }
        public string Name { get; set; }
        public string FCTag { get; set; }
        public string Title { get; set; }
        public string JobIco { get; set; }
        public string Race { get; set; }
        public string RenderDistance { get; set; }
        public string TimeControl { get; set; }
        public string Weather { get; set; }
        public string StatusEffect { get; set; }
        public string ForceWeather { get; set; }
        public string Gender { get; set; }
        public string EyeBrowType { get; set; }
        public string Clan { get; set; }
        public string BodyType { get; set; }
        public string EntityType { get; set; }
        public string FreezeFacial { get; set; }
        public string Territory { get; set; }
        public string DataPath { get; set; }
        public string DataHead { get; set; }
        public string NPCName { get; set; }
        public string NPCModel { get; set; }
        public BodyOffsets Body { get; set; }
        public string TailorMuscle { get; set; }
        public string NameHeight { get; set; }
        public string TailType { get; set; }
        public string ModelType { get; set; }
        public string Transparency { get; set; }
        public string Head { get; set; }
        public string Hair { get; set; }
        public string Jaw { get; set; }
        public string LimbalR { get; set; }
        public string LimbalG { get; set; }
        public string LimbalB { get; set; }
        public string RenderToggle { get; set; }
        public string Music { get; set; }
        public string Music2 { get; set; }
        public string RHeight { get; set; }
        public string RBust { get; set; }
        public string Highlights { get; set; }
        public string HighlightTone { get; set; }
        public string LimbalEyes { get; set; }
        public string Skintone { get; set; }
        public string FOV2 { get; set; }
        public string HairTone { get; set; }
        public string RightEye { get; set; }
        public string LeftEye { get; set; }
        public string Eye { get; set; }
        public string Nose { get; set; }
        public string Lips { get; set; }
        public string LipsTone { get; set; }
        public string FacePaint { get; set; }
        public string FacePaintColor { get; set; }
        public string FacialFeatures { get; set; }
        public string Emote { get; set; }
        public string EmoteOld { get; set; }
        public string EmoteSpeed1 { get; set; }
        public string EmoteSpeed2 { get; set; }
        public string CameraHeight2 { get; set; }
        public string CameraYAMin { get; set; }
        public string CameraYAMax { get; set; }
        public string Voices { get; set; }
        public string CamX { get; set; }
        public string CamY { get; set; }
        public string CamZ { get; set; }
        public string CamViewX { get; set; }
        public string CamViewY { get; set; }
        public string CamViewZ { get; set; }
        public string CamAngleX { get; set; }
        public string CamAngleY { get; set; }
        public string Max { get; set; }
        public string Min { get; set; }
        public string CZoom { get; set; }
        public string FOVC { get; set; }
        public string FOVMAX { get; set; }
        public string HeadPiece { get; set; }
        public string HeadV { get; set; }
        public string HeadDye { get; set; }
        public string Chest { get; set; }
        public string ChestV { get; set; }
        public string ChestDye { get; set; }
        public string Arms { get; set; }
        public string ArmsV { get; set; }
        public string ArmsDye { get; set; }
        public string Legs { get; set; }
        public string LegsV { get; set; }
        public string LegsDye { get; set; }
        public string Feet { get; set; }
        public string FeetVa { get; set; }
        public string FeetDye { get; set; }
        public string Ear { get; set; }
        public string EarVa { get; set; }
        public string Neck { get; set; }
        public string NeckVa { get; set; }
        public string Wrist { get; set; }
        public string WristVa { get; set; }
        public string RFinger { get; set; }
        public string RFingerVa { get; set; }
        public string LFinger { get; set; }
        public string LFingerVa { get; set; }
        public string Job { get; set; }
        public string WeaponBase { get; set; }
        public string WeaponV { get; set; }
        public string WeaponDye { get; set; }
        public string WeaponX { get; set; }
        public string WeaponY { get; set; }
        public string WeaponZ { get; set; }
        public string Offhand { get; set; }
        public string OffhandBase { get; set; }
        public string OffhandV { get; set; }
        public string OffhandDye { get; set; }
        public string OffhandX { get; set; }
        public string OffhandY { get; set; }
        public string OffhandZ { get; set; }
        public string OffhandRed { get; set; }
        public string OffhandGreen { get; set; }
        public string OffhandBlue { get; set; }
        public string WeaponRed { get; set; }
        public string WeaponBlue { get; set; }
        public string WeaponGreen { get; set; }
        public string SkinRedPigment { get; set; }
        public string SkinGreenPigment { get; set; }
        public string SkinBluePigment { get; set; }
        public string SkinRedGloss { get; set; }
        public string SkinGreenGloss { get; set; }
        public string SkinBlueGloss { get; set; }
        public string HairRedPigment { get; set; }
        public string HairGreenPigment { get; set; }
        public string HairBluePigment { get; set; }
        public string HairGlowRed { get; set; }
        public string HairGlowGreen { get; set; }
        public string HairGlowBlue { get; set; }
        public string HighlightRedPigment { get; set; }
        public string HighlightGreenPigment { get; set; }
        public string HighlightBluePigment { get; set; }
        public string LeftEyeRed { get; set; }
        public string LeftEyeGreen { get; set; }
        public string LeftEyeBlue { get; set; }
        public string RightEyeRed { get; set; }
        public string RightEyeGreen { get; set; }
        public string RightEyeBlue { get; set; }
        public string LipsBrightness { get; set; }
        public string LipsR { get; set; }
        public string LipsG { get; set; }
        public string LipsB { get; set; }
        public string CameraUpDown { get; set; }
    }

    [Serializable]
    public struct BodyOffsets
    {
        [XmlAttribute("Base")]
        public string Base { get; set; }

        public PositionOffsets Position { get; set; }
        public Vector3Offsets Bust { get; set; }
        public string Height { get; set; }
        public string Wetness { get; set; }
        public string SWetness { get; set; }
        public Vector3Offsets Scale { get; set; }
        public string MuscleTone { get; set; }
        public string TailSize { get; set; }
    }

    [Serializable]
    public struct PositionOffsets
    {
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
        public string Rotation { get; set; }
        public string Rotation2 { get; set; }
        public string Rotation3 { get; set; }
        public string Rotation4 { get; set; }

        public string HeadX { get; set; }
        public string NoseX { get; set; }
        public string NostrilsX { get; set; }
        public string ChinX { get; set; }
        public string LOutEyebrowX { get; set; }
        public string ROutEyebrowX { get; set; }
        public string LInEyebrowX { get; set; }
        public string RInEyebrowX { get; set; }
        public string LEyeX { get; set; }
        public string REyeX { get; set; }
        public string LEyelidX { get; set; }
        public string REyelidX { get; set; }
        public string LLowEyelidX { get; set; }
        public string RLowEyelidX { get; set; }
        public string LEarX { get; set; }
        public string REarX { get; set; }
        public string LCheekX { get; set; }
        public string RCheekX { get; set; }
        public string LMouthX { get; set; }
        public string RMouthX { get; set; }
        public string LUpLipX { get; set; }
        public string RUpLipX { get; set; }
        public string LLowLipX { get; set; }
        public string RLowLipX { get; set; }
        public string NeckX { get; set; }
        public string SternumX { get; set; }
        public string TorsoX { get; set; }
        public string WaistX { get; set; }
        public string LShoulderX { get; set; }
        public string RShoulderX { get; set; }
        public string LClavicleX { get; set; }
        public string RClavicleX { get; set; }
        public string LBreastX { get; set; }
        public string RBreastX { get; set; }
        public string LArmX { get; set; }
        public string RArmX { get; set; }
        public string LElbowX { get; set; }
        public string RElbowX { get; set; }
        public string LForearmX { get; set; }
        public string RForearmX { get; set; }
        public string LWristX { get; set; }
        public string RWristX { get; set; }
        public string LHandX { get; set; }
        public string RHandX { get; set; }
        public string LThumbX { get; set; }
        public string RThumbX { get; set; }
        public string LThumb2X { get; set; }
        public string RThumb2X { get; set; }
        public string LIndexX { get; set; }
        public string RIndexX { get; set; }
        public string LIndex2X { get; set; }
        public string RIndex2X { get; set; }
        public string LMiddleX { get; set; }
        public string RMiddleX { get; set; }
        public string LMiddle2X { get; set; }
        public string RMiddle2X { get; set; }
        public string LRingX { get; set; }
        public string RRingX { get; set; }
        public string LRing2X { get; set; }
        public string RRing2X { get; set; }
        public string LPinkyX { get; set; }
        public string RPinkyX { get; set; }
        public string LPinky2X { get; set; }
        public string RPinky2X { get; set; }
        public string PelvisX { get; set; }
        public string TailX { get; set; }
        public string LThighX { get; set; }
        public string RThighX { get; set; }
        public string LKneeX { get; set; }
        public string RKneeX { get; set; }
        public string LCalfX { get; set; }
        public string RCalfX { get; set; }
        public string LFootX { get; set; }
        public string RFootX { get; set; }
        public string LToesX { get; set; }
        public string RToesX { get; set; }
        public string HeadY { get; set; }
        public string NoseY { get; set; }
        public string NostrilsY { get; set; }
        public string ChinY { get; set; }
        public string LOutEyebrowY { get; set; }
        public string ROutEyebrowY { get; set; }
        public string LInEyebrowY { get; set; }
        public string RInEyebrowY { get; set; }
        public string LEyeY { get; set; }
        public string REyeY { get; set; }
        public string LEyelidY { get; set; }
        public string REyelidY { get; set; }
        public string LLowEyelidY { get; set; }
        public string RLowEyelidY { get; set; }
        public string LEarY { get; set; }
        public string REarY { get; set; }
        public string LCheekY { get; set; }
        public string RCheekY { get; set; }
        public string LMouthY { get; set; }
        public string RMouthY { get; set; }
        public string LUpLipY { get; set; }
        public string RUpLipY { get; set; }
        public string LLowLipY { get; set; }
        public string RLowLipY { get; set; }
        public string NeckY { get; set; }
        public string SternumY { get; set; }
        public string TorsoY { get; set; }
        public string WaistY { get; set; }
        public string LShoulderY { get; set; }
        public string RShoulderY { get; set; }
        public string LClavicleY { get; set; }
        public string RClavicleY { get; set; }
        public string LBreastY { get; set; }
        public string RBreastY { get; set; }
        public string LArmY { get; set; }
        public string RArmY { get; set; }
        public string LElbowY { get; set; }
        public string RElbowY { get; set; }
        public string LForearmY { get; set; }
        public string RForearmY { get; set; }
        public string LWristY { get; set; }
        public string RWristY { get; set; }
        public string LHandY { get; set; }
        public string RHandY { get; set; }
        public string LThumbY { get; set; }
        public string RThumbY { get; set; }
        public string LThumb2Y { get; set; }
        public string RThumb2Y { get; set; }
        public string LIndexY { get; set; }
        public string RIndexY { get; set; }
        public string LIndex2Y { get; set; }
        public string RIndex2Y { get; set; }
        public string LMiddleY { get; set; }
        public string RMiddleY { get; set; }
        public string LMiddle2Y { get; set; }
        public string RMiddle2Y { get; set; }
        public string LRingY { get; set; }
        public string RRingY { get; set; }
        public string LRing2Y { get; set; }
        public string RRing2Y { get; set; }
        public string LPinkyY { get; set; }
        public string RPinkyY { get; set; }
        public string LPinky2Y { get; set; }
        public string RPinky2Y { get; set; }
        public string PelvisY { get; set; }
        public string TailY { get; set; }
        public string LThighY { get; set; }
        public string RThighY { get; set; }
        public string LKneeY { get; set; }
        public string RKneeY { get; set; }
        public string LCalfY { get; set; }
        public string RCalfY { get; set; }
        public string LFootY { get; set; }
        public string RFootY { get; set; }
        public string LToesY { get; set; }
        public string RToesY { get; set; }
        public string HeadZ { get; set; }
        public string NoseZ { get; set; }
        public string NostrilsZ { get; set; }
        public string ChinZ { get; set; }
        public string LOutEyebrowZ { get; set; }
        public string ROutEyebrowZ { get; set; }
        public string LInEyebrowZ { get; set; }
        public string RInEyebrowZ { get; set; }
        public string LEyeZ { get; set; }
        public string REyeZ { get; set; }
        public string LEyelidZ { get; set; }
        public string REyelidZ { get; set; }
        public string LLowEyelidZ { get; set; }
        public string RLowEyelidZ { get; set; }
        public string LEarZ { get; set; }
        public string REarZ { get; set; }
        public string LCheekZ { get; set; }
        public string RCheekZ { get; set; }
        public string LMouthZ { get; set; }
        public string RMouthZ { get; set; }
        public string LUpLipZ { get; set; }
        public string RUpLipZ { get; set; }
        public string LLowLipZ { get; set; }
        public string RLowLipZ { get; set; }
        public string NeckZ { get; set; }
        public string SternumZ { get; set; }
        public string TorsoZ { get; set; }
        public string WaistZ { get; set; }
        public string LShoulderZ { get; set; }
        public string RShoulderZ { get; set; }
        public string LClavicleZ { get; set; }
        public string RClavicleZ { get; set; }
        public string LBreastZ { get; set; }
        public string RBreastZ { get; set; }
        public string LArmZ { get; set; }
        public string RArmZ { get; set; }
        public string LElbowZ { get; set; }
        public string RElbowZ { get; set; }
        public string LForearmZ { get; set; }
        public string RForearmZ { get; set; }
        public string LWristZ { get; set; }
        public string RWristZ { get; set; }
        public string LHandZ { get; set; }
        public string RHandZ { get; set; }
        public string LThumbZ { get; set; }
        public string RThumbZ { get; set; }
        public string LThumb2Z { get; set; }
        public string RThumb2Z { get; set; }
        public string LIndexZ { get; set; }
        public string RIndexZ { get; set; }
        public string LIndex2Z { get; set; }
        public string RIndex2Z { get; set; }
        public string LMiddleZ { get; set; }
        public string RMiddleZ { get; set; }
        public string LMiddle2Z { get; set; }
        public string RMiddle2Z { get; set; }
        public string LRingZ { get; set; }
        public string RRingZ { get; set; }
        public string LRing2Z { get; set; }
        public string RRing2Z { get; set; }
        public string LPinkyZ { get; set; }
        public string RPinkyZ { get; set; }
        public string LPinky2Z { get; set; }
        public string RPinky2Z { get; set; }
        public string PelvisZ { get; set; }
        public string TailZ { get; set; }
        public string LThighZ { get; set; }
        public string RThighZ { get; set; }
        public string LKneeZ { get; set; }
        public string RKneeZ { get; set; }
        public string LCalfZ { get; set; }
        public string RCalfZ { get; set; }
        public string LFootZ { get; set; }
        public string RFootZ { get; set; }
        public string LToesZ { get; set; }
        public string RToesZ { get; set; }
        public string HeadW { get; set; }
        public string NoseW { get; set; }
        public string NostrilsW { get; set; }
        public string ChinW { get; set; }
        public string LOutEyebrowW { get; set; }
        public string ROutEyebrowW { get; set; }
        public string LInEyebrowW { get; set; }
        public string RInEyebrowW { get; set; }
        public string LEyeW { get; set; }
        public string REyeW { get; set; }
        public string LEyelidW { get; set; }
        public string REyelidW { get; set; }
        public string LLowEyelidW { get; set; }
        public string RLowEyelidW { get; set; }
        public string LEarW { get; set; }
        public string REarW { get; set; }
        public string LCheekW { get; set; }
        public string RCheekW { get; set; }
        public string LMouthW { get; set; }
        public string RMouthW { get; set; }
        public string LUpLipW { get; set; }
        public string RUpLipW { get; set; }
        public string LLowLipW { get; set; }
        public string RLowLipW { get; set; }
        public string NeckW { get; set; }
        public string SternumW { get; set; }
        public string TorsoW { get; set; }
        public string WaistW { get; set; }
        public string LShoulderW { get; set; }
        public string RShoulderW { get; set; }
        public string LClavicleW { get; set; }
        public string RClavicleW { get; set; }
        public string LBreastW { get; set; }
        public string RBreastW { get; set; }
        public string LArmW { get; set; }
        public string RArmW { get; set; }
        public string LElbowW { get; set; }
        public string RElbowW { get; set; }
        public string LForearmW { get; set; }
        public string RForearmW { get; set; }
        public string LWristW { get; set; }
        public string RWristW { get; set; }
        public string LHandW { get; set; }
        public string RHandW { get; set; }
        public string LThumbW { get; set; }
        public string RThumbW { get; set; }
        public string LThumb2W { get; set; }
        public string RThumb2W { get; set; }
        public string LIndexW { get; set; }
        public string RIndexW { get; set; }
        public string LIndex2W { get; set; }
        public string RIndex2W { get; set; }
        public string LMiddleW { get; set; }
        public string RMiddleW { get; set; }
        public string LMiddle2W { get; set; }
        public string RMiddle2W { get; set; }
        public string LRingW { get; set; }
        public string RRingW { get; set; }
        public string LRing2W { get; set; }
        public string RRing2W { get; set; }
        public string LPinkyW { get; set; }
        public string RPinkyW { get; set; }
        public string LPinky2W { get; set; }
        public string RPinky2W { get; set; }
        public string PelvisW { get; set; }
        public string TailW { get; set; }
        public string LThighW { get; set; }
        public string RThighW { get; set; }
        public string LKneeW { get; set; }
        public string RKneeW { get; set; }
        public string LCalfW { get; set; }
        public string RCalfW { get; set; }
        public string LFootW { get; set; }
        public string RFootW { get; set; }
        public string LToesW { get; set; }
        public string RToesW { get; set; }
    }

    [Serializable]
    public struct Vector3Offsets
    {
        [XmlAttribute("Base")]
        public string Base { get; set; }

        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
    }
}