import 'package:flutter/material.dart'; 

import 'sign_in_form.dart';

void showCustomDialog(BuildContext context, {required ValueChanged onValue}) {
  showGeneralDialog(
    context: context,
    barrierLabel: "Barrier",
    barrierDismissible: true,
    barrierColor: Colors.black.withOpacity(0.5),
    transitionDuration: const Duration(milliseconds: 400),
    pageBuilder: (_, __, ___) {
      return Center(
        child: Container(
          height: 670,
          margin: const EdgeInsets.symmetric(horizontal: 16),
          padding: const EdgeInsets.symmetric(vertical: 32, horizontal: 24),
          decoration: BoxDecoration(
            color: Colors.white.withOpacity(0.95),
            borderRadius: BorderRadius.circular(40),
            boxShadow: [
              BoxShadow(
                color: Colors.black.withOpacity(0.3),
                offset: const Offset(0, 30),
                blurRadius: 60,
              ),
              const BoxShadow(
                color: Colors.black45,
                offset: Offset(0, 30),
                blurRadius: 60,
              ),
            ],
          ),
          child: const Scaffold(
            backgroundColor: Colors.transparent,
            body: Stack(
              clipBehavior: Clip.none,
              children: [
                SingleChildScrollView(
                  child: Column(
                    children: [
                      Padding(
                        padding: EdgeInsets.symmetric(vertical : 40),
                        child: Text(
                        "Giriş Yap",
                        style: TextStyle(
                          fontSize: 44,
                          fontFamily: "Poppins",
                          fontWeight: FontWeight.w600,
                        ),
                      ),
                      ),
                      
                     
                      SignInForm(),
                       Padding(
                        padding: EdgeInsets.symmetric(vertical: 60),
                        child: Text(
                          "SahaApp tarafından size sağlanan Kullanıcı bilgileriniz sadece kişiye özel kullanım için oluşturulmaktadır. 3. şahıslar ile paylaşmayınız. Adınıza yapılan işlemlerden SahaApp sorumlu değildir.",
                          textAlign: TextAlign.center,
                        ),
                      ),
                      
                       
                    ],
                  ),
                ),
                 
              ],
            ),
          ),
        ),
      );
    },
    transitionBuilder: (_, anim, __, child) {
      Tween<Offset> tween; 
      tween = Tween(begin: const Offset(0, -1), end: Offset.zero);

      return SlideTransition(
        position: tween.animate(
          CurvedAnimation(parent: anim, curve: Curves.easeInOut),
        ), 
        child: child,
      );
    },
  ).then(onValue);
}
