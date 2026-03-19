package com.MM.ManuscriptMaster.dto.request;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder
public class UserCreateRequest {
    private String nickname;
    private String login;
    private String email;
    private String password;
    private String avatar;
}
