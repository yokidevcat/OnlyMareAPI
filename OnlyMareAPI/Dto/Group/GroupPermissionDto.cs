using OnlyMare.API.Data;
using OnlyMare.API.Data.Enum;
using MessagePack;

namespace OnlyMare.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPermissionDto(GroupData Group, GroupPermissions Permissions) : GroupDto(Group);