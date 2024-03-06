PGDMP  )                    |            CarBook    15.5    16.0 R    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    34499    CarBook    DATABASE     �   CREATE DATABASE "CarBook" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = icu LOCALE = 'en_US.UTF-8' ICU_LOCALE = 'en-US';
    DROP DATABASE "CarBook";
                postgres    false            �            1259    34505    Abouts    TABLE     �   CREATE TABLE public."Abouts" (
    "Id" uuid NOT NULL,
    "Title" text NOT NULL,
    "Description" text NOT NULL,
    "ImageUrl" text NOT NULL
);
    DROP TABLE public."Abouts";
       public         heap    postgres    false            �            1259    34652    Authors    TABLE     �   CREATE TABLE public."Authors" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "ImageUrl" text NOT NULL,
    "Description" text NOT NULL
);
    DROP TABLE public."Authors";
       public         heap    postgres    false            �            1259    34512    Banners    TABLE     �   CREATE TABLE public."Banners" (
    "Id" uuid NOT NULL,
    "Title" text NOT NULL,
    "Description" text NOT NULL,
    "VideoDescription" text NOT NULL,
    "VideoUrl" text NOT NULL
);
    DROP TABLE public."Banners";
       public         heap    postgres    false            �            1259    34659    Blogs    TABLE       CREATE TABLE public."Blogs" (
    "Id" uuid NOT NULL,
    "Title" text NOT NULL,
    "CoverImageUrl" text NOT NULL,
    "CreatedDate" timestamp without time zone NOT NULL,
    "AuthorId" uuid NOT NULL,
    "CategoryId" uuid NOT NULL,
    "Description" text DEFAULT ''::text NOT NULL
);
    DROP TABLE public."Blogs";
       public         heap    postgres    false            �            1259    34519    Brands    TABLE     S   CREATE TABLE public."Brands" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL
);
    DROP TABLE public."Brands";
       public         heap    postgres    false            �            1259    34601    CarDescriptions    TABLE     y   CREATE TABLE public."CarDescriptions" (
    "Id" uuid NOT NULL,
    "Detail" text NOT NULL,
    "CarId" uuid NOT NULL
);
 %   DROP TABLE public."CarDescriptions";
       public         heap    postgres    false            �            1259    34613    CarFeatures    TABLE     �   CREATE TABLE public."CarFeatures" (
    "Id" uuid NOT NULL,
    "FeatureId" uuid NOT NULL,
    "CarId" uuid NOT NULL,
    "Avaible" boolean NOT NULL
);
 !   DROP TABLE public."CarFeatures";
       public         heap    postgres    false            �            1259    34589    Cars    TABLE     �  CREATE TABLE public."Cars" (
    "Id" uuid NOT NULL,
    "BrandId" uuid NOT NULL,
    "Model" text NOT NULL,
    "CoverImageUrl" text NOT NULL,
    "BigImageUrl" text NOT NULL,
    "Km" integer NOT NULL,
    "Transmission" text NOT NULL,
    "Seat" integer NOT NULL,
    "Luggage" integer NOT NULL,
    "Fuel" text NOT NULL,
    "PricesId" uuid DEFAULT '00000000-0000-0000-0000-000000000000'::uuid NOT NULL
);
    DROP TABLE public."Cars";
       public         heap    postgres    false            �            1259    34526 
   Categories    TABLE     W   CREATE TABLE public."Categories" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL
);
     DROP TABLE public."Categories";
       public         heap    postgres    false            �            1259    34726    Comments    TABLE        CREATE TABLE public."Comments" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "CreateDate" timestamp without time zone NOT NULL,
    "Description" text NOT NULL,
    "ImageUrl" text DEFAULT 'user.png'::text NOT NULL,
    "BlogId" uuid NOT NULL
);
    DROP TABLE public."Comments";
       public         heap    postgres    false            �            1259    34533    Contacts    TABLE     �   CREATE TABLE public."Contacts" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "Email" text NOT NULL,
    "Subject" text NOT NULL,
    "Message" text NOT NULL,
    "SendDate" timestamp without time zone NOT NULL
);
    DROP TABLE public."Contacts";
       public         heap    postgres    false            �            1259    34540    Features    TABLE     U   CREATE TABLE public."Features" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL
);
    DROP TABLE public."Features";
       public         heap    postgres    false            �            1259    34547    FooterAdresses    TABLE     �   CREATE TABLE public."FooterAdresses" (
    "Id" uuid NOT NULL,
    "Description" text NOT NULL,
    "Adress" text NOT NULL,
    "Phone" text NOT NULL,
    "Email" text NOT NULL
);
 $   DROP TABLE public."FooterAdresses";
       public         heap    postgres    false            �            1259    34554 	   Locations    TABLE     ^   CREATE TABLE public."Locations" (
    "Id" uuid NOT NULL,
    "LocationName" text NOT NULL
);
    DROP TABLE public."Locations";
       public         heap    postgres    false            �            1259    34696    Prices    TABLE       CREATE TABLE public."Prices" (
    "Id" uuid NOT NULL,
    "AmountDay" integer DEFAULT 0 NOT NULL,
    "AmountHour" integer DEFAULT 0 NOT NULL,
    "AmountWeek" integer DEFAULT 0 NOT NULL,
    "CarId" uuid DEFAULT '00000000-0000-0000-0000-000000000000'::uuid NOT NULL
);
    DROP TABLE public."Prices";
       public         heap    postgres    false            �            1259    34568    Services    TABLE     �   CREATE TABLE public."Services" (
    "Id" uuid NOT NULL,
    "Title" text NOT NULL,
    "Description" text NOT NULL,
    "IconUrl" text NOT NULL
);
    DROP TABLE public."Services";
       public         heap    postgres    false            �            1259    34575    SocialMedias    TABLE     �   CREATE TABLE public."SocialMedias" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "Url" text NOT NULL,
    "IconUrl" text NOT NULL
);
 "   DROP TABLE public."SocialMedias";
       public         heap    postgres    false            �            1259    34713 	   TagClouds    TABLE     s   CREATE TABLE public."TagClouds" (
    "Id" uuid NOT NULL,
    "Title" text NOT NULL,
    "BlogId" uuid NOT NULL
);
    DROP TABLE public."TagClouds";
       public         heap    postgres    false            �            1259    34582    Testimonials    TABLE     �   CREATE TABLE public."Testimonials" (
    "Id" uuid NOT NULL,
    "Name" text NOT NULL,
    "Title" text NOT NULL,
    "Comment" text NOT NULL,
    "ImageUrl" text NOT NULL
);
 "   DROP TABLE public."Testimonials";
       public         heap    postgres    false            �            1259    34500    __EFMigrationsHistory    TABLE     �   CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);
 +   DROP TABLE public."__EFMigrationsHistory";
       public         heap    postgres    false            �          0    34505    Abouts 
   TABLE DATA           L   COPY public."Abouts" ("Id", "Title", "Description", "ImageUrl") FROM stdin;
    public          postgres    false    215   �`       �          0    34652    Authors 
   TABLE DATA           L   COPY public."Authors" ("Id", "Name", "ImageUrl", "Description") FROM stdin;
    public          postgres    false    229   �b       �          0    34512    Banners 
   TABLE DATA           a   COPY public."Banners" ("Id", "Title", "Description", "VideoDescription", "VideoUrl") FROM stdin;
    public          postgres    false    216   �c       �          0    34659    Blogs 
   TABLE DATA           y   COPY public."Blogs" ("Id", "Title", "CoverImageUrl", "CreatedDate", "AuthorId", "CategoryId", "Description") FROM stdin;
    public          postgres    false    230   �c       �          0    34519    Brands 
   TABLE DATA           0   COPY public."Brands" ("Id", "Name") FROM stdin;
    public          postgres    false    217   {e       �          0    34601    CarDescriptions 
   TABLE DATA           D   COPY public."CarDescriptions" ("Id", "Detail", "CarId") FROM stdin;
    public          postgres    false    227   �e       �          0    34613    CarFeatures 
   TABLE DATA           N   COPY public."CarFeatures" ("Id", "FeatureId", "CarId", "Avaible") FROM stdin;
    public          postgres    false    228   �e       �          0    34589    Cars 
   TABLE DATA           �   COPY public."Cars" ("Id", "BrandId", "Model", "CoverImageUrl", "BigImageUrl", "Km", "Transmission", "Seat", "Luggage", "Fuel", "PricesId") FROM stdin;
    public          postgres    false    226   f       �          0    34526 
   Categories 
   TABLE DATA           4   COPY public."Categories" ("Id", "Name") FROM stdin;
    public          postgres    false    218   �f       �          0    34726    Comments 
   TABLE DATA           e   COPY public."Comments" ("Id", "Name", "CreateDate", "Description", "ImageUrl", "BlogId") FROM stdin;
    public          postgres    false    233   g       �          0    34533    Contacts 
   TABLE DATA           ]   COPY public."Contacts" ("Id", "Name", "Email", "Subject", "Message", "SendDate") FROM stdin;
    public          postgres    false    219   /g       �          0    34540    Features 
   TABLE DATA           2   COPY public."Features" ("Id", "Name") FROM stdin;
    public          postgres    false    220   �g       �          0    34547    FooterAdresses 
   TABLE DATA           [   COPY public."FooterAdresses" ("Id", "Description", "Adress", "Phone", "Email") FROM stdin;
    public          postgres    false    221   �g       �          0    34554 	   Locations 
   TABLE DATA           ;   COPY public."Locations" ("Id", "LocationName") FROM stdin;
    public          postgres    false    222   �h       �          0    34696    Prices 
   TABLE DATA           Z   COPY public."Prices" ("Id", "AmountDay", "AmountHour", "AmountWeek", "CarId") FROM stdin;
    public          postgres    false    231   �h       �          0    34568    Services 
   TABLE DATA           M   COPY public."Services" ("Id", "Title", "Description", "IconUrl") FROM stdin;
    public          postgres    false    223   \i       �          0    34575    SocialMedias 
   TABLE DATA           H   COPY public."SocialMedias" ("Id", "Name", "Url", "IconUrl") FROM stdin;
    public          postgres    false    224   �j       �          0    34713 	   TagClouds 
   TABLE DATA           >   COPY public."TagClouds" ("Id", "Title", "BlogId") FROM stdin;
    public          postgres    false    232   �j       �          0    34582    Testimonials 
   TABLE DATA           V   COPY public."Testimonials" ("Id", "Name", "Title", "Comment", "ImageUrl") FROM stdin;
    public          postgres    false    225   k       �          0    34500    __EFMigrationsHistory 
   TABLE DATA           R   COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
    public          postgres    false    214   �l       �           2606    34511    Abouts PK_Abouts 
   CONSTRAINT     T   ALTER TABLE ONLY public."Abouts"
    ADD CONSTRAINT "PK_Abouts" PRIMARY KEY ("Id");
 >   ALTER TABLE ONLY public."Abouts" DROP CONSTRAINT "PK_Abouts";
       public            postgres    false    215            �           2606    34658    Authors PK_Authors 
   CONSTRAINT     V   ALTER TABLE ONLY public."Authors"
    ADD CONSTRAINT "PK_Authors" PRIMARY KEY ("Id");
 @   ALTER TABLE ONLY public."Authors" DROP CONSTRAINT "PK_Authors";
       public            postgres    false    229            �           2606    34518    Banners PK_Banners 
   CONSTRAINT     V   ALTER TABLE ONLY public."Banners"
    ADD CONSTRAINT "PK_Banners" PRIMARY KEY ("Id");
 @   ALTER TABLE ONLY public."Banners" DROP CONSTRAINT "PK_Banners";
       public            postgres    false    216            �           2606    34665    Blogs PK_Blogs 
   CONSTRAINT     R   ALTER TABLE ONLY public."Blogs"
    ADD CONSTRAINT "PK_Blogs" PRIMARY KEY ("Id");
 <   ALTER TABLE ONLY public."Blogs" DROP CONSTRAINT "PK_Blogs";
       public            postgres    false    230            �           2606    34525    Brands PK_Brands 
   CONSTRAINT     T   ALTER TABLE ONLY public."Brands"
    ADD CONSTRAINT "PK_Brands" PRIMARY KEY ("Id");
 >   ALTER TABLE ONLY public."Brands" DROP CONSTRAINT "PK_Brands";
       public            postgres    false    217            �           2606    34607 "   CarDescriptions PK_CarDescriptions 
   CONSTRAINT     f   ALTER TABLE ONLY public."CarDescriptions"
    ADD CONSTRAINT "PK_CarDescriptions" PRIMARY KEY ("Id");
 P   ALTER TABLE ONLY public."CarDescriptions" DROP CONSTRAINT "PK_CarDescriptions";
       public            postgres    false    227            �           2606    34617    CarFeatures PK_CarFeatures 
   CONSTRAINT     ^   ALTER TABLE ONLY public."CarFeatures"
    ADD CONSTRAINT "PK_CarFeatures" PRIMARY KEY ("Id");
 H   ALTER TABLE ONLY public."CarFeatures" DROP CONSTRAINT "PK_CarFeatures";
       public            postgres    false    228            �           2606    34595    Cars PK_Cars 
   CONSTRAINT     P   ALTER TABLE ONLY public."Cars"
    ADD CONSTRAINT "PK_Cars" PRIMARY KEY ("Id");
 :   ALTER TABLE ONLY public."Cars" DROP CONSTRAINT "PK_Cars";
       public            postgres    false    226            �           2606    34532    Categories PK_Categories 
   CONSTRAINT     \   ALTER TABLE ONLY public."Categories"
    ADD CONSTRAINT "PK_Categories" PRIMARY KEY ("Id");
 F   ALTER TABLE ONLY public."Categories" DROP CONSTRAINT "PK_Categories";
       public            postgres    false    218                       2606    34733    Comments PK_Comments 
   CONSTRAINT     X   ALTER TABLE ONLY public."Comments"
    ADD CONSTRAINT "PK_Comments" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public."Comments" DROP CONSTRAINT "PK_Comments";
       public            postgres    false    233            �           2606    34539    Contacts PK_Contacts 
   CONSTRAINT     X   ALTER TABLE ONLY public."Contacts"
    ADD CONSTRAINT "PK_Contacts" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public."Contacts" DROP CONSTRAINT "PK_Contacts";
       public            postgres    false    219            �           2606    34546    Features PK_Features 
   CONSTRAINT     X   ALTER TABLE ONLY public."Features"
    ADD CONSTRAINT "PK_Features" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public."Features" DROP CONSTRAINT "PK_Features";
       public            postgres    false    220            �           2606    34553     FooterAdresses PK_FooterAdresses 
   CONSTRAINT     d   ALTER TABLE ONLY public."FooterAdresses"
    ADD CONSTRAINT "PK_FooterAdresses" PRIMARY KEY ("Id");
 N   ALTER TABLE ONLY public."FooterAdresses" DROP CONSTRAINT "PK_FooterAdresses";
       public            postgres    false    221            �           2606    34560    Locations PK_Locations 
   CONSTRAINT     Z   ALTER TABLE ONLY public."Locations"
    ADD CONSTRAINT "PK_Locations" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public."Locations" DROP CONSTRAINT "PK_Locations";
       public            postgres    false    222            �           2606    34574    Services PK_Services 
   CONSTRAINT     X   ALTER TABLE ONLY public."Services"
    ADD CONSTRAINT "PK_Services" PRIMARY KEY ("Id");
 B   ALTER TABLE ONLY public."Services" DROP CONSTRAINT "PK_Services";
       public            postgres    false    223            �           2606    34581    SocialMedias PK_SocialMedias 
   CONSTRAINT     `   ALTER TABLE ONLY public."SocialMedias"
    ADD CONSTRAINT "PK_SocialMedias" PRIMARY KEY ("Id");
 J   ALTER TABLE ONLY public."SocialMedias" DROP CONSTRAINT "PK_SocialMedias";
       public            postgres    false    224                       2606    34719    TagClouds PK_TagClouds 
   CONSTRAINT     Z   ALTER TABLE ONLY public."TagClouds"
    ADD CONSTRAINT "PK_TagClouds" PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public."TagClouds" DROP CONSTRAINT "PK_TagClouds";
       public            postgres    false    232            �           2606    34588    Testimonials PK_Testimonials 
   CONSTRAINT     `   ALTER TABLE ONLY public."Testimonials"
    ADD CONSTRAINT "PK_Testimonials" PRIMARY KEY ("Id");
 J   ALTER TABLE ONLY public."Testimonials" DROP CONSTRAINT "PK_Testimonials";
       public            postgres    false    225            �           2606    34504 .   __EFMigrationsHistory PK___EFMigrationsHistory 
   CONSTRAINT     {   ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");
 \   ALTER TABLE ONLY public."__EFMigrationsHistory" DROP CONSTRAINT "PK___EFMigrationsHistory";
       public            postgres    false    214                       2606    34700    Prices Prices_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public."Prices"
    ADD CONSTRAINT "Prices_pkey" PRIMARY KEY ("Id");
 @   ALTER TABLE ONLY public."Prices" DROP CONSTRAINT "Prices_pkey";
       public            postgres    false    231            �           1259    34676    IX_Blogs_AuthorId    INDEX     M   CREATE INDEX "IX_Blogs_AuthorId" ON public."Blogs" USING btree ("AuthorId");
 '   DROP INDEX public."IX_Blogs_AuthorId";
       public            postgres    false    230            �           1259    34677    IX_Blogs_CategoryId    INDEX     Q   CREATE INDEX "IX_Blogs_CategoryId" ON public."Blogs" USING btree ("CategoryId");
 )   DROP INDEX public."IX_Blogs_CategoryId";
       public            postgres    false    230            �           1259    34645    IX_CarDescriptions_CarId    INDEX     b   CREATE UNIQUE INDEX "IX_CarDescriptions_CarId" ON public."CarDescriptions" USING btree ("CarId");
 .   DROP INDEX public."IX_CarDescriptions_CarId";
       public            postgres    false    227            �           1259    34646    IX_CarFeatures_CarId    INDEX     S   CREATE INDEX "IX_CarFeatures_CarId" ON public."CarFeatures" USING btree ("CarId");
 *   DROP INDEX public."IX_CarFeatures_CarId";
       public            postgres    false    228            �           1259    34647    IX_CarFeatures_FeatureId    INDEX     [   CREATE INDEX "IX_CarFeatures_FeatureId" ON public."CarFeatures" USING btree ("FeatureId");
 .   DROP INDEX public."IX_CarFeatures_FeatureId";
       public            postgres    false    228            �           1259    34650    IX_Cars_BrandId    INDEX     I   CREATE INDEX "IX_Cars_BrandId" ON public."Cars" USING btree ("BrandId");
 %   DROP INDEX public."IX_Cars_BrandId";
       public            postgres    false    226                       1259    34739    IX_Comments_BlogId    INDEX     O   CREATE INDEX "IX_Comments_BlogId" ON public."Comments" USING btree ("BlogId");
 (   DROP INDEX public."IX_Comments_BlogId";
       public            postgres    false    233            �           1259    34706    IX_Prices_CarId    INDEX     P   CREATE UNIQUE INDEX "IX_Prices_CarId" ON public."Prices" USING btree ("CarId");
 %   DROP INDEX public."IX_Prices_CarId";
       public            postgres    false    231                       1259    34725    IX_TagClouds_BlogId    INDEX     Q   CREATE INDEX "IX_TagClouds_BlogId" ON public."TagClouds" USING btree ("BlogId");
 )   DROP INDEX public."IX_TagClouds_BlogId";
       public            postgres    false    232                       2606    34666    Blogs FK_Blogs_Authors_AuthorId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Blogs"
    ADD CONSTRAINT "FK_Blogs_Authors_AuthorId" FOREIGN KEY ("AuthorId") REFERENCES public."Authors"("Id") ON DELETE CASCADE;
 M   ALTER TABLE ONLY public."Blogs" DROP CONSTRAINT "FK_Blogs_Authors_AuthorId";
       public          postgres    false    230    229    3578                       2606    34671 $   Blogs FK_Blogs_Categories_CategoryId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Blogs"
    ADD CONSTRAINT "FK_Blogs_Categories_CategoryId" FOREIGN KEY ("CategoryId") REFERENCES public."Categories"("Id") ON DELETE CASCADE;
 R   ALTER TABLE ONLY public."Blogs" DROP CONSTRAINT "FK_Blogs_Categories_CategoryId";
       public          postgres    false    230    218    3552            	           2606    34608 -   CarDescriptions FK_CarDescriptions_Cars_CarId    FK CONSTRAINT     �   ALTER TABLE ONLY public."CarDescriptions"
    ADD CONSTRAINT "FK_CarDescriptions_Cars_CarId" FOREIGN KEY ("CarId") REFERENCES public."Cars"("Id") ON DELETE CASCADE;
 [   ALTER TABLE ONLY public."CarDescriptions" DROP CONSTRAINT "FK_CarDescriptions_Cars_CarId";
       public          postgres    false    226    227    3569            
           2606    34618 %   CarFeatures FK_CarFeatures_Cars_CarId    FK CONSTRAINT     �   ALTER TABLE ONLY public."CarFeatures"
    ADD CONSTRAINT "FK_CarFeatures_Cars_CarId" FOREIGN KEY ("CarId") REFERENCES public."Cars"("Id") ON DELETE CASCADE;
 S   ALTER TABLE ONLY public."CarFeatures" DROP CONSTRAINT "FK_CarFeatures_Cars_CarId";
       public          postgres    false    228    3569    226                       2606    34623 -   CarFeatures FK_CarFeatures_Features_FeatureId    FK CONSTRAINT     �   ALTER TABLE ONLY public."CarFeatures"
    ADD CONSTRAINT "FK_CarFeatures_Features_FeatureId" FOREIGN KEY ("FeatureId") REFERENCES public."Features"("Id") ON DELETE CASCADE;
 [   ALTER TABLE ONLY public."CarFeatures" DROP CONSTRAINT "FK_CarFeatures_Features_FeatureId";
       public          postgres    false    3556    220    228                       2606    34596    Cars FK_Cars_Brands_BrandId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Cars"
    ADD CONSTRAINT "FK_Cars_Brands_BrandId" FOREIGN KEY ("BrandId") REFERENCES public."Brands"("Id") ON DELETE CASCADE;
 I   ALTER TABLE ONLY public."Cars" DROP CONSTRAINT "FK_Cars_Brands_BrandId";
       public          postgres    false    217    226    3550                       2606    34734 !   Comments FK_Comments_Blogs_BlogId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Comments"
    ADD CONSTRAINT "FK_Comments_Blogs_BlogId" FOREIGN KEY ("BlogId") REFERENCES public."Blogs"("Id") ON DELETE CASCADE;
 O   ALTER TABLE ONLY public."Comments" DROP CONSTRAINT "FK_Comments_Blogs_BlogId";
       public          postgres    false    3582    233    230                       2606    34707    Prices FK_Prices_Cars_CarId    FK CONSTRAINT     �   ALTER TABLE ONLY public."Prices"
    ADD CONSTRAINT "FK_Prices_Cars_CarId" FOREIGN KEY ("CarId") REFERENCES public."Cars"("Id") ON DELETE CASCADE;
 I   ALTER TABLE ONLY public."Prices" DROP CONSTRAINT "FK_Prices_Cars_CarId";
       public          postgres    false    3569    231    226                       2606    34720 #   TagClouds FK_TagClouds_Blogs_BlogId    FK CONSTRAINT     �   ALTER TABLE ONLY public."TagClouds"
    ADD CONSTRAINT "FK_TagClouds_Blogs_BlogId" FOREIGN KEY ("BlogId") REFERENCES public."Blogs"("Id") ON DELETE CASCADE;
 Q   ALTER TABLE ONLY public."TagClouds" DROP CONSTRAINT "FK_TagClouds_Blogs_BlogId";
       public          postgres    false    232    230    3582            �   �  x�US͎�0>�O17.m��eK9��8�
	���ę������exދ�mS�)�=���ds�x�ٮ7w��������w����e�������x����������A��A->�,#i*u�!�����b+r1q&V3�I��p �j}dq�;���}1Rv�k!�1���c���W)�}� �����h���4��8KGO�������&9*p/�J���E���A�X�d��u�Δ�ә �H#�4Pq�%ky�B/E>�1DO:I���s��zT�����Q>����{�)��{���Q��(7�=�Qln����ז��B��;���:�M޶��CF�|lVp����5�=Ϡ��^HpEL��I5�EG�r��< �ENR��9V��Z���QB�p+'�S.�ܦ�S56i#"������Z� �R��3��g�&�b�¼�uZFL9鵧wݹ��<���6�K�7;+m2m��[V'k���
���t�c��{:,�u���/�9>�      �   �   x�M��n�@�kx
? ��8r�)Ӧ�t2^r��k����RZ��f��mz.�K��[?�n�q��~]G���խ85?A+al2�%��8���N'�\4�K>�P��P���r��I�"$q�R�R�����j5Rd�b���x%���C����y��7�=�����B�H�"��L@�3B�,�M� ^ޱ/�mp*����fq����m۾ ��h�      �      x������ � �      �   �  x���j�0��ާ�XK�e+��zjK�P(�Hol�՟�y��Bs��nޫ^��s��o��186�w�Fcˤ=Ce6*k55Ckڮ�J��-C�4�����1S��#�����>�O��L��6�����.O�C�g<Я��_�h�d�`��7���n�PYiĨz�:�:&�3Ec�֜�Aj�QT�*n�mre�۸n�c8ʞ7nt�h��K����n���g�����L�D@�W������h�(dJ
X�����$�3�X�OP2�%���O��p�G�k�N){S��?��{�=�4��Go���E����jfK�z
5|#Xl�v�h�wn�n;d�o�e�{68���"�{#e��;�ע��tz�ԩ�Wqf8q�q0Ns��[�7D%�Q���z����8��      �   @   x�3355K5L��MI30�5173е0HL�5IKK45��04NM��M-JNMI-VpJͫ����� ���      �      x������ � �      �      x������ � �      �   |   x�m�1�0 ������q��&&V7v*"��� ���k2h��\�FiaԔ����ɢ�>Ӊp��5Ɂ9&k�b���>��t����]�q~<7��ƽo.q����6{��6,�      �   q   x�M�11 �ڼ�� B���M��3��������(8�	��`���JaVv�c}����ݩ���mo�����%U������T�A��5!�!+k��s{>Zk��'�      �      x������ � �      �   �   x�5�1�0 ��|�U��qډ�����N[�e���[?��n8�t�{Q�h(���lu0�E�$�"w�;N��x,Ȫ �4�"XL�GKdQ�eZ>U��i[纭n���6��������[q�>��a�4m�"词��n�0�      �      x������ � �      �   �   x�E��n�0Dk���s898�\���FJ�g6Ē��כ����pMRL�Fz3�[ߟ������:��Wù荒mɶu����-&p�h�}L�A��6��6s���ĺy{�.�<q��$*��%�+ir�X�('��.��{�n�NQ�Q�h�̦�F�)Ѳ���=��_u����˒�~�ִ����=�OCsπ�>4[����QGcc(?MY��-{^�      �      x������ � �      �   S   x���� �j��9c?6�%�f�B
ݩ����vY�	�Mc�S�\�$�y0sу�o�=,i�PB�v��HSX�5V}�Z���      �     x���;N1�z�> %���)UDE3��0�w7��������!�����g3z�Z�:�L(�t08֒��y�N������ṕRw�%Z�s]���D�"p�r'ܶfr�JM=�9;^�E.;�Pc�E�Ĺ𥒨Exny����y��آ�)��p[i���y��Q���0�`�RM?�*4�I��#�b����M����g�Vi��֠'�!H)�t�&e�N��ނY�ԃ�P�f60hζ7��q֡{�H��oƷ�~��}�%�      �      x������ � �      �   S   x����  �3�R�BA:�[x�&ƫ����]P�!zk�:l����6��{��Q�D��
(ځg;A�/��.W�>�}�Z$l�      �   {  x�ՒKn1�מS��Q��/'!��B�CB�vyb���@�[��.O�D�����>�G��rә�k5��\:��~�,�+�O#�E�H��;�I�v��>n�V�\Wp۲%ȡ ���-f��JM�.\B�!���P�pW���Z��V[Z�bXo 8�˂��R;m_�{�t��o�%䰇�5�� �9����ob��r��^�B\zi��丱~�!���Ȏ����w�옶X��|T�Sbc���Ijn&��2R�\oÎ5=b�Ì��?�����ө:�IK�<7�7=�Y�>z'�M��c����&�~����):���\��s�i��1�K�:/���^��p5�>Q��/v���r{�������~����z�*      �   �   x�e���0�g�0��������hB�m�I/���0���}��'� ����툇��
_	$l�jmt[�3�6蓋�%d�����@B�e�'	)�2i���&�0�N��'���|P�b]��l�d�lcX�{uwf�A�Z��h���Ţ�?W��(�n�7!����1���O2     