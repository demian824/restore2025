import { z } from "zod";

const passwordValidation = new RegExp(
    /(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;&quot;:;'?/&gt;.&lt;,]).*$/
)

export const registerSchema = z.object({
    email: z.string().email(),
    password: z.string().regex(passwordValidation, {
        message: '{assword must contain 1 lowercase character, 1 uppercase character, 1 number, 1 special and be 6-10 characters '
    })

});

export type RegisterSchema = z.infer<typeof registerSchema>;