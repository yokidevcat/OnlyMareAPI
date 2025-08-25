﻿using OnlyMare.API.Data.Enum;
using MessagePack;

namespace OnlyMare.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record BulkPermissionsDto(Dictionary<string, UserPermissions> AffectedUsers, Dictionary<string, GroupUserPreferredPermissions> AffectedGroups);
