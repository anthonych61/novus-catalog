package com.example.novus_catalog.entities;

import jakarta.persistence.*;

@Entity
@Table(name = "USERS")
public class Users {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String account;
    private String password;

    @Transient
    private String oldMentorPassword;

    @Transient
    private String newMentorPassword;

    @Transient
    private String oldAdminPassword;

    @Transient
    private String newAdminPassword;

    public Users() {}

    // getters and setters
    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getAccount() {
        return account;
    }

    public void setAccount(String account) {
        this.account = account;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getOldMentorPassword() {
        return oldMentorPassword;
    }

    public void setOldMentorPassword(String oldMentorPassword) {
        this.oldMentorPassword = oldMentorPassword;
    }

    public String getNewMentorPassword() {
        return newMentorPassword;
    }

    public void setNewMentorPassword(String newMentorPassword) {
        this.newMentorPassword = newMentorPassword;
    }

    public String getOldAdminPassword() {
        return oldAdminPassword;
    }

    public void setOldAdminPassword(String oldAdminPassword) {
        this.oldAdminPassword = oldAdminPassword;
    }

    public String getNewAdminPassword() {
        return newAdminPassword;
    }

    public void setNewAdminPassword(String newAdminPassword) {
        this.newAdminPassword = newAdminPassword;
    }

}
