package com.example.novus_catalog.repository;

import com.example.novus_catalog.entities.Users;
import jakarta.transaction.Transactional;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

@Repository
public interface UserRepository extends JpaRepository<Users, Long> {

    @Modifying
    @Transactional // Required for update operations
    @Query(value = "UPDATE USERS SET PASSWORD = :PASSWORD WHERE ACCOUNT = :ACCOUNT", nativeQuery = true)
    void update (@Param("ACCOUNT") String account, @Param("PASSWORD") String password);

    boolean existsByAccountAndPassword(String username, String password);
}
