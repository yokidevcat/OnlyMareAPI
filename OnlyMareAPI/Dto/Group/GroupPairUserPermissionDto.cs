using OnlyMare.API.Data;
using OnlyMare.API.Data.Enum;
using MessagePack;

namespace OnlyMare.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairUserPermissionDto(GroupData Group, UserData User, GroupUserPreferredPermissions GroupPairPermissions) : GroupPairDto(Group, User);