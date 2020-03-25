export default function EditAlbum(album){
    return `
    <section class="content__album">
        <h4>${album.title}</h4>
    </section>
    
    <section class="update-album">
        <input class="update-album__title" type="text" value="${album.title}">
        <input class="update-album__image" type="text" value="${album.image}">
        <input class="update-album__recordLabel" type="text" value="${album.recordLabel}">
        <input class="update-album__id" type="hidden" value="${album.albumId}">
        <input class="update-album__artistId" type="hidden" value="${album.artistId}">
        <button class="update-album__submit">Save Changes</button>
    </section>
`;
}