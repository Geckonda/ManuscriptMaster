package com.MM.ManuscriptMaster.domain.model;

import lombok.AllArgsConstructor;
import lombok.Getter;

@AllArgsConstructor
@Getter
public enum BookModificator {
    PUBLIC("Публично"),
    PRIVATE("Приватно");

    private final String displayName;
}
