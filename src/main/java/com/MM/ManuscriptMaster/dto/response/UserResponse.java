package com.MM.ManuscriptMaster.dto.response;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder
public class UserResponse {
    private Long id;
    private String nickname;
    private String login;
    private String email;
    private String avatar;
    private List<BookResponse> books;
    private List<CharacterResponse> characters;
}
