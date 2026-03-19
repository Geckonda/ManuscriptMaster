package com.MM.ManuscriptMaster.dto.request;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Builder
public class CharacterCreateRequest {
    private String name;
    private int height;
    private int weight;
    private String personality;
    private String appearance;
    private String conflict;
    private String goals;
    private String motivation;
    private String history;
    private String picture;
    private Long authorId;
}
