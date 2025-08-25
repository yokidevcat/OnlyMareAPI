using OnlyMare.API.Data;
using OnlyMare.API.Data.Enum;
using MessagePack;

namespace OnlyMare.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserPermissionsDto(UserData User, UserPermissions Permissions) : UserDto(User);
