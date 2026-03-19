package com.MM.ManuscriptMaster.mapper;

import com.MM.ManuscriptMaster.domain.model.User;
import com.MM.ManuscriptMaster.dto.response.UserSimpleResponse;
import org.springframework.stereotype.Component;

@Component
public class UserMapper {

    public UserSimpleResponse toSimpleResponse(User user) {
        if (user == null) {
            return null;
        }
        return UserSimpleResponse.builder()
                .id(user.getId())
                .nickname(user.getNickname())
                .login(user.getLogin())
                .email(user.getEmail())
                .avatar(user.getAvatar())
                .build();
    }
}
