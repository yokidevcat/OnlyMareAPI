﻿using OnlyMare.API.Data;
using OnlyMare.API.Data.Enum;
using OnlyMare.API.Dto;
using OnlyMare.API.Dto.CharaData;
using OnlyMare.API.Dto.Group;
using OnlyMare.API.Dto.User;

namespace OnlyMare.API.SignalR;

public interface ILightlessHub
{
    const int ApiVersion = 33;
    const string Path = "/lightless";

    Task<bool> CheckClientHealth();

    Task Client_DownloadReady(Guid requestId);
    Task Client_GroupChangePermissions(GroupPermissionDto groupPermission);
    Task Client_GroupDelete(GroupDto groupDto);
    Task Client_GroupPairChangeUserInfo(GroupPairUserInfoDto userInfo);
    Task Client_GroupPairJoined(GroupPairFullInfoDto groupPairInfoDto);
    Task Client_GroupPairLeft(GroupPairDto groupPairDto);
    Task Client_GroupSendFullInfo(GroupFullInfoDto groupInfo);
    Task Client_GroupSendInfo(GroupInfoDto groupInfo);
    Task Client_ReceiveServerMessage(MessageSeverity messageSeverity, string message);
    Task Client_UpdateSystemInfo(SystemInfoDto systemInfo);
    Task Client_UserAddClientPair(UserPairDto dto);
    Task Client_UserReceiveCharacterData(OnlineUserCharaDataDto dataDto);
    Task Client_UserReceiveUploadStatus(UserDto dto);
    Task Client_UserRemoveClientPair(UserDto dto);
    Task Client_UserSendOffline(UserDto dto);
    Task Client_UserSendOnline(OnlineUserIdentDto dto);
    Task Client_UserUpdateOtherPairPermissions(UserPermissionsDto dto);
    Task Client_UpdateUserIndividualPairStatusDto(UserIndividualPairStatusDto dto);
    Task Client_UserUpdateProfile(UserDto dto);
    Task Client_UserUpdateSelfPairPermissions(UserPermissionsDto dto);
    Task Client_UserUpdateDefaultPermissions(DefaultPermissionsDto dto);
    Task Client_GroupChangeUserPairPermissions(GroupPairUserPermissionDto dto);
    Task Client_GposeLobbyJoin(UserData userData);
    Task Client_GposeLobbyLeave(UserData userData);
    Task Client_GposeLobbyPushCharacterData(CharaDataDownloadDto charaDownloadDto);
    Task Client_GposeLobbyPushPoseData(UserData userData, PoseData poseData);
    Task Client_GposeLobbyPushWorldData(UserData userData, WorldData worldData);

    Task<ConnectionDto> GetConnectionDto();

    Task GroupBanUser(GroupPairDto dto, string reason);
    Task GroupChangeGroupPermissionState(GroupPermissionDto dto);
    Task GroupChangeOwnership(GroupPairDto groupPair);
    Task<bool> GroupChangePassword(GroupPasswordDto groupPassword);
    Task GroupClear(GroupDto group);
    Task<GroupJoinDto> GroupCreate();
    Task<List<string>> GroupCreateTempInvite(GroupDto group, int amount);
    Task GroupDelete(GroupDto group);
    Task<List<BannedGroupUserDto>> GroupGetBannedUsers(GroupDto group);
    Task<GroupJoinInfoDto> GroupJoin(GroupPasswordDto passwordedGroup);
    Task<bool> GroupJoinFinalize(GroupJoinDto passwordedGroup);
    Task GroupLeave(GroupDto group);
    Task GroupRemoveUser(GroupPairDto groupPair);
    Task GroupSetUserInfo(GroupPairUserInfoDto groupPair);
    Task<List<GroupFullInfoDto>> GroupsGetAll();
    Task GroupUnbanUser(GroupPairDto groupPair);
    Task<int> GroupPrune(GroupDto group, int days, bool execute);

    Task UserAddPair(UserDto user);
    Task UserDelete();
    Task<List<OnlineUserIdentDto>> UserGetOnlinePairs(CensusDataDto? censusDataDto);
    Task<List<UserFullPairDto>> UserGetPairedClients();
    Task<UserProfileDto> UserGetProfile(UserDto dto);
    Task UserPushData(UserCharaDataMessageDto dto);
    Task UserRemovePair(UserDto userDto);
    Task UserSetProfile(UserProfileDto userDescription);
    Task UserUpdateDefaultPermissions(DefaultPermissionsDto defaultPermissionsDto);
    Task SetBulkPermissions(BulkPermissionsDto dto);

    Task<CharaDataFullDto?> CharaDataCreate();
    Task<CharaDataFullDto?> CharaDataUpdate(CharaDataUpdateDto updateDto);
    Task<bool> CharaDataDelete(string id);
    Task<CharaDataMetaInfoDto?> CharaDataGetMetainfo(string id);
    Task<CharaDataDownloadDto?> CharaDataDownload(string id);
    Task<List<CharaDataFullDto>> CharaDataGetOwn();
    Task<List<CharaDataMetaInfoDto>> CharaDataGetShared();
    Task<CharaDataFullDto?> CharaDataAttemptRestore(string id);

    Task<string> GposeLobbyCreate();
    Task<List<UserData>> GposeLobbyJoin(string lobbyId);
    Task<bool> GposeLobbyLeave();
    Task GposeLobbyPushCharacterData(CharaDataDownloadDto charaDownloadDto);
    Task GposeLobbyPushPoseData(PoseData poseData);
    Task GposeLobbyPushWorldData(WorldData worldData);
}