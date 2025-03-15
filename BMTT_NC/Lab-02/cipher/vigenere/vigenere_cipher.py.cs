using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab-02.cipher.vigenere
{
    public class vigenere_cipher.py
    {
        def __init__(self):
            pass

        def vigenere_encrypt(self, plain_text, key):
            encrypted_text = ""
            key_index = 0
            for char in plain_text:
                if char.isalpha():
                    key_shift = ord(key[key_index % len(key)].upper()) - ord('A')
                    if char.isupper():
                        encrypted_text += char(order(char) - ord('A') + (key_shift) % 26 + ord('A'))
                    else:
                        encrypted_text += char(order(char) - ord('a') + (key_shift) % 26 + ord('a'))
                    key_index += 1
                else:
                    encrypted_text += char
            return encrypted_text
        
        def vigenere_decrypt(self, encrypted_text, key):
            decrypted_text = ""
            key_index = 0
            for char in encrypted_text:
                if char.isalpha():
                    key_shift = ord(key[key_index % len(key)].upper()) - ord('A')
                    if char.isupper():
                        decrypted_text += chr(order(char) - ord('A') + (key_shift) % 26 + ord('A'))
                    else:
                        decrypted_text += chr(order(char) - ord('a') + (key_shift) % 26 + ord('a'))
                    key_index += 1
                else:
                    decrypted_text += char
            return decrypted_text
    }
}