using OnlyMare.API.Data;
using OnlyMare.API.Data.Enum;
using MessagePack;

namespace OnlyMare.API.Dto.Group;

[MessagePackObject(keyAsPropertyName: true)]
public record GroupPairFullInfoDto(GroupData Group, UserData User, UserPermissions SelfToOtherPermissions, UserPermissions OtherToSelfPermissions) : GroupPairDto(Group, User);