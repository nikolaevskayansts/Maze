﻿#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





extern void WheelHit_get_normal_mD59C9DB64546E22ADE3CA24DEE638F6F8168F162 (void);
extern void WheelHit_get_forwardSlip_m1BA6AA2379368EFE2200B92AB4CA20F1AD537CCE (void);
extern void WheelHit_get_sidewaysSlip_m7E27E0B36C1CC096C56B8815B7C1E7D380D6627B (void);
extern void WheelCollider_get_radius_m68CC3DE301E0C6226E85F99D853365DA1244CD1F (void);
extern void WheelCollider_set_motorTorque_m4958AAF7D867CF7570420F9BAFAF04DC904F02A8 (void);
extern void WheelCollider_set_brakeTorque_mB9B216C57C275470907C7DB35185E2F192DC8DAB (void);
extern void WheelCollider_set_steerAngle_m7BF83B27D8956355F873537939BE9F35CF3113C3 (void);
extern void WheelCollider_GetWorldPose_m8C41FA2AE9ED543AB94A6E3226523A2FE83FA890 (void);
extern void WheelCollider_GetGroundHit_mCB73878577BC5AAEBEA8572FA62326C4C71B3EF2 (void);
static Il2CppMethodPointer s_methodPointers[9] = 
{
	WheelHit_get_normal_mD59C9DB64546E22ADE3CA24DEE638F6F8168F162,
	WheelHit_get_forwardSlip_m1BA6AA2379368EFE2200B92AB4CA20F1AD537CCE,
	WheelHit_get_sidewaysSlip_m7E27E0B36C1CC096C56B8815B7C1E7D380D6627B,
	WheelCollider_get_radius_m68CC3DE301E0C6226E85F99D853365DA1244CD1F,
	WheelCollider_set_motorTorque_m4958AAF7D867CF7570420F9BAFAF04DC904F02A8,
	WheelCollider_set_brakeTorque_mB9B216C57C275470907C7DB35185E2F192DC8DAB,
	WheelCollider_set_steerAngle_m7BF83B27D8956355F873537939BE9F35CF3113C3,
	WheelCollider_GetWorldPose_m8C41FA2AE9ED543AB94A6E3226523A2FE83FA890,
	WheelCollider_GetGroundHit_mCB73878577BC5AAEBEA8572FA62326C4C71B3EF2,
};
extern void WheelHit_get_normal_mD59C9DB64546E22ADE3CA24DEE638F6F8168F162_AdjustorThunk (void);
extern void WheelHit_get_forwardSlip_m1BA6AA2379368EFE2200B92AB4CA20F1AD537CCE_AdjustorThunk (void);
extern void WheelHit_get_sidewaysSlip_m7E27E0B36C1CC096C56B8815B7C1E7D380D6627B_AdjustorThunk (void);
static Il2CppTokenAdjustorThunkPair s_adjustorThunks[3] = 
{
	{ 0x06000001, WheelHit_get_normal_mD59C9DB64546E22ADE3CA24DEE638F6F8168F162_AdjustorThunk },
	{ 0x06000002, WheelHit_get_forwardSlip_m1BA6AA2379368EFE2200B92AB4CA20F1AD537CCE_AdjustorThunk },
	{ 0x06000003, WheelHit_get_sidewaysSlip_m7E27E0B36C1CC096C56B8815B7C1E7D380D6627B_AdjustorThunk },
};
static const int32_t s_InvokerIndices[9] = 
{
	4518,
	4466,
	4466,
	4466,
	3676,
	3676,
	3676,
	1564,
	2484,
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_VehiclesModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_VehiclesModule_CodeGenModule = 
{
	"UnityEngine.VehiclesModule.dll",
	9,
	s_methodPointers,
	3,
	s_adjustorThunks,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};